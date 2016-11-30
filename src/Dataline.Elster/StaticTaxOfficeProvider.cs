// <copyright file="StaticTaxOfficeProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Dataline.Elster
{
    /// <summary>
    /// Ein <see cref="ITaxOfficeProvider"/> basierend auf statischen Tabellen
    /// </summary>
    public sealed class StaticTaxOfficeProvider : ITaxOfficeProvider
    {
        private static readonly IEnumerable<TaxOfficeInfo> _taxOffices;

        static StaticTaxOfficeProvider()
        {
            var taxOfficesBase = new List<TaxOfficeInfo>(StaticTaxOfficeData.Live200701.Count + StaticTaxOfficeData.Test200701.Count);
            taxOfficesBase.AddRange(StaticTaxOfficeData.Live200701);
            taxOfficesBase.AddRange(StaticTaxOfficeData.Test200701);

            Debug.Assert(!GetFailedEntries(taxOfficesBase).Any(), "Ensure that we don't have incompatible changes.");
            var taxOffices = taxOfficesBase.ToDictionary(x => x.BufaNr, x => new List<TaxOfficeInfo>() { x });
            foreach (var changes in StaticTaxOfficeData.Changes)
            {
                var date = changes.Key.Date;
                foreach (var change in changes.Value)
                {
                    List<TaxOfficeInfo> oldEntries;
                    if (!taxOffices.TryGetValue(change.BufaNr, out oldEntries))
                    {
                        oldEntries = new List<TaxOfficeInfo>();
                        taxOffices.Add(change.BufaNr, oldEntries);
                    }

                    TaxOfficeInfo newEntry;
                    switch (change.ChangeType)
                    {
                        case TaxOfficeChangeType.New:
                            Debug.Assert(oldEntries.Count(x => x.ValidUntil == null) == 0, "We must not have a tax office with the same tax office number.");
                            newEntry = ProcessNew(date, change);
                            break;
                        case TaxOfficeChangeType.ChangeName:
                            Debug.Assert(oldEntries.Any(x => x.ValidUntil == null), "Ensure that the previous entry exists.");
                            newEntry = ProcessChangeName(date, change, oldEntries);
                            break;
                        case TaxOfficeChangeType.ChangeValid:
                            newEntry = ProcessChangeValid(date, change, oldEntries);
                            break;
                        case TaxOfficeChangeType.RedirectTo:
                            newEntry = ProcessRedirectTo(date, change, oldEntries);
                            break;
                        default:
                            throw new InvalidOperationException($"Unknown change type {change.ChangeType}");
                    }

                    oldEntries.Add(newEntry);
                }

                // Sanity check
                Debug.Assert(!GetFailedEntries(taxOffices.SelectMany(x => x.Value)).Any(), "Ensure that all changes could be applied without error.");
            }

            _taxOffices = taxOffices.OrderBy(x => x.Key).SelectMany(x => x.Value).ToList();
        }

        /// <inheritdoc/>
        public IQueryable<TaxOfficeInfo> Query(DateTime? validFor = null)
        {
            var taxOffices = _taxOffices.AsQueryable()
                                        .ValidFor(validFor);
            return taxOffices;
        }

        private static TaxOfficeInfo ProcessNew(DateTime date, TaxOfficeChange change)
        {
            return new TaxOfficeInfo(change.BufaNr, change.Name, change.SupportsElsterAnmeldung.GetValueOrDefault(), change.Province, change.IsTest, date);
        }

        private static TaxOfficeInfo ProcessChangeName(DateTime date, TaxOfficeChange change, List<TaxOfficeInfo> oldEntries)
        {
            var oldEntry = oldEntries.Single(x => x.ValidUntil == null);

            // Alten Eintrag löschen
            oldEntries.Remove(oldEntry);
            if (oldEntry.ValidSince == null || oldEntry.ValidSince.Value != date)
            {
                // Neuen "alten" Eintrag erstellen, wenn das "Gültig von"-Datum nicht dem aktuellen Datum entspricht.
                oldEntries.Add(
                    new TaxOfficeInfo(
                        oldEntry.BufaNr,
                        oldEntry.Name,
                        oldEntry.SupportsElsterAnmeldung,
                        oldEntry.Province,
                        oldEntry.IsTest,
                        oldEntry.ValidSince,
                        date,
                        oldEntry.RedirectTo));
            }

            return new TaxOfficeInfo(
                oldEntry.BufaNr,
                change.Name ?? oldEntry.Name,
                change.SupportsElsterAnmeldung ?? oldEntry.SupportsElsterAnmeldung,
                oldEntry.Province,
                oldEntry.IsTest,
                date,
                redirectTo: oldEntry.RedirectTo);
        }

        private static TaxOfficeInfo ProcessChangeValid(DateTime date, TaxOfficeChange change, List<TaxOfficeInfo> oldEntries)
        {
            if (change.IsValid)
            {
                Debug.Assert(oldEntries.Count != 0 && oldEntries.All(x => x.ValidUntil.HasValue), "Ensure that we have entries that are all invalid.");
                var oldEntry = oldEntries.OrderByDescending(x => x.ValidUntil).First();
                return new TaxOfficeInfo(
                    oldEntry.BufaNr,
                    oldEntry.Name,
                    oldEntry.SupportsElsterAnmeldung,
                    oldEntry.Province,
                    oldEntry.IsTest,
                    date,
                    redirectTo: oldEntry.RedirectTo);
            }
            else
            {
                Debug.Assert(oldEntries.Any(x => x.ValidUntil == null), "Ensure that we have at least one active tax office.");
                var oldEntry = oldEntries.SingleOrDefault(x => x.ValidUntil == null);
                oldEntries.Remove(oldEntry);
                return new TaxOfficeInfo(
                    oldEntry.BufaNr,
                    oldEntry.Name,
                    oldEntry.SupportsElsterAnmeldung,
                    oldEntry.Province,
                    oldEntry.IsTest,
                    oldEntry.ValidSince,
                    date,
                    oldEntry.RedirectTo);
            }
        }

        private static TaxOfficeInfo ProcessRedirectTo(DateTime date, TaxOfficeChange change, List<TaxOfficeInfo> oldEntries)
        {
            Debug.Assert(oldEntries.Any(x => x.ValidUntil == null), "Ensure that the tax office exists.");
            var oldEntry = oldEntries.Single(x => x.ValidUntil == null);

            // Alten Eintrag löschen
            oldEntries.Remove(oldEntry);
            if (!change.IsValid)
            {
                return new TaxOfficeInfo(
                    oldEntry.BufaNr,
                    oldEntry.Name,
                    change.SupportsElsterAnmeldung ?? oldEntry.SupportsElsterAnmeldung,
                    oldEntry.Province,
                    oldEntry.IsTest,
                    oldEntry.ValidSince,
                    date,
                    change.NewBufaNr);
            }

            if (oldEntry.ValidSince == null || oldEntry.ValidSince.Value != date)
            {
                // Neuen "alten" Eintrag erstellen, wenn das "Gültig von"-Datum nicht dem aktuellen Datum entspricht.
                oldEntries.Add(
                    new TaxOfficeInfo(
                        oldEntry.BufaNr,
                        oldEntry.Name,
                        oldEntry.SupportsElsterAnmeldung,
                        oldEntry.Province,
                        oldEntry.IsTest,
                        oldEntry.ValidSince,
                        date,
                        oldEntry.RedirectTo));
            }

            return new TaxOfficeInfo(
                oldEntry.BufaNr,
                oldEntry.Name,
                change.SupportsElsterAnmeldung ?? oldEntry.SupportsElsterAnmeldung,
                oldEntry.Province,
                oldEntry.IsTest,
                date,
                redirectTo: change.NewBufaNr);
        }

        private static IEnumerable<IGrouping<int, TaxOfficeInfo>> GetFailedEntries(IEnumerable<TaxOfficeInfo> taxOffices)
        {
            var result = taxOffices.Where(x => x.ValidUntil == null).GroupBy(x => x.BufaNr).Where(x => x.Count() != 1);
            return result;
        }
    }
}
