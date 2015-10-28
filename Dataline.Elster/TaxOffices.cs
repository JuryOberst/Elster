// <copyright file="TaxOffices.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Zur Abfrage von Finanzämtern
    /// </summary>
    public class TaxOffices
    {
        private static readonly Dictionary<int, Province> _provinceIdsToProvince = new Dictionary<int, Province>
            {
                { 10, Province.Saarland },
                { 11, Province.Berlin },
                { 21, Province.SchleswigHolstein },
                { 22, Province.Hamburg },
                { 23, Province.Niedersachsen },
                { 24, Province.Bremen },
                { 26, Province.Hessen },
                { 27, Province.RheinlandPfalz },
                { 28, Province.BadenWuerttemberg },
                { 30, Province.Brandenburg },
                { 31, Province.SachsenAnhalt },
                { 32, Province.Sachsen },
                { 40, Province.MecklenburgVorpommern },
                { 41, Province.Thueringen },
                { 51, Province.NordrheinWestfalen },
                { 52, Province.NordrheinWestfalen },
                { 53, Province.NordrheinWestfalen },
                { 91, Province.Bayern },
                { 92, Province.Bayern },
            };

        private readonly ILookup<int, TaxOfficeInfo> _taxOffices;

        static TaxOffices()
        {
            Active = new TaxOffices(new StaticTaxOfficeProvider());
            All = new TaxOffices(new StaticTaxOfficeProvider(), null);
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxOffices"/> Klasse.
        /// </summary>
        /// <param name="provider">Anbieter von Finanzämtern</param>
        public TaxOffices(ITaxOfficeProvider provider)
            : this(provider, DateTime.Now)
        {
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxOffices"/> Klasse.
        /// </summary>
        /// <param name="provider">Anbieter von Finanzämtern</param>
        /// <param name="validFor">Das Datum für das die abgefragten Finanzämter gültig sein müssen</param>
        public TaxOffices(ITaxOfficeProvider provider, DateTime? validFor)
        {
            ValidFor = validFor;
            Provider = provider;
            _taxOffices = provider.Query(validFor).ToLookup(x => x.BufaNr);
        }

        /// <summary>
        /// Holt oder setzt die aktuell aktiven Finanzämter
        /// </summary>
        [NotNull]
        public static TaxOffices Active { get; set; }

        /// <summary>
        /// Holt oder setzt die vollständige Liste alle Finanzämter (egal, ob aktiv oder inaktiv)
        /// </summary>
        [NotNull]
        public static TaxOffices All { get; set; }

        /// <summary>
        /// Holt die Finanzamtsanbieter über den intern die Finanzämter abgefragt werden
        /// </summary>
        [NotNull]
        public ITaxOfficeProvider Provider { get; private set; }

        /// <summary>
        /// Holt das Datum für das die Finanzämter gültig sein müssen
        /// </summary>
        public DateTime? ValidFor { get; }

        /// <summary>
        /// Lädt alle Finanzamtsinformationen für ein Finanzamt
        /// </summary>
        /// <param name="taxOfficeId">Die Bundesfinanzamtsnummer</param>
        /// <returns>Alle Informationen über das abgefragte Finanzamt</returns>
        /// <remarks>
        /// Es können mehrere Informationen zurückgeliefert werden, wenn
        /// wir keinen Wert für <see cref="ValidFor"/> haben. Dadurch erhalten
        /// wir den Änderungsverlauf zu einem Finanzamt.
        /// </remarks>
        [NotNull]
        public IReadOnlyList<TaxOfficeInfo> Load(int taxOfficeId)
        {
            return Load(taxOfficeId, false);
        }

        /// <summary>
        /// Lädt alle Finanzamtsinformationen für ein Finanzamt
        /// </summary>
        /// <param name="taxOfficeId">Die Bundesfinanzamtsnummer</param>
        /// <param name="resolveToActive">Wenn es Umleitungen gibt, dann die Informatinen der neuen Finanzämter zurückliefern</param>
        /// <returns>Alle Informationen über das abgefragte Finanzamt</returns>
        /// <remarks>
        /// Es können mehrere Informationen zurückgeliefert werden, wenn
        /// wir keinen Wert für <see cref="ValidFor"/> haben. Dadurch erhalten
        /// wir den Änderungsverlauf zu einem Finanzamt.
        /// Wenn wir eine Umleitung haben, dann können wir die Informationen der neuen
        /// Finanzämter erhalten, wenn auf mehr als ein Finanzamt umgeleitet werden muss.
        /// </remarks>
        [NotNull]
        public IReadOnlyList<TaxOfficeInfo> Load(int taxOfficeId, bool resolveToActive)
        {
            var result = new List<TaxOfficeInfo>();

            var items = _taxOffices[taxOfficeId].OrderByDescending(x => x.ValidUntil, NullIsLargestComparer.Default).ToList();
            var item = items.FirstOrDefault();
            if (!resolveToActive || item != null || ValidFor == null)
            {
                // Direkt gefunden. Redirect nur anwenden, wenn der Eintrag nicht mehr gültig ist oder kein LStA verarbeiten kann.
                if (resolveToActive && item?.RedirectTo != null && !item.SupportsElsterAnmeldung && item.RedirectTo.Count != 0)
                {
                    result.AddRange(item.RedirectTo.SelectMany(x => Load(x, true)));
                }
                else
                {
                    result.Add(item);
                }

                return result;
            }

            if (!ReferenceEquals(All, this))
            {
                // In der Gesamt-Liste nach dem Finanzamt suchen
                items = All._taxOffices[taxOfficeId].Where(x => x.ValidSince == null || x.ValidSince.Value <= ValidFor.Value).ToList();
                item = items.OrderByDescending(x => x.ValidUntil, NullIsLargestComparer.Default).FirstOrDefault();
                if (item != null)
                {
                    if (item.RedirectTo != null && item.RedirectTo.Count != 0)
                    {
                        // FA mit Redirect gefunden -> Nach neuem FA suchen.
                        result.AddRange(item.RedirectTo.SelectMany(x => Load(x, true)));
                    }
                    else
                    {
                        result.Add(item);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Ermittelt das Bundesland für eine Bundesfinanzamtsnummer
        /// </summary>
        /// <param name="taxOfficeId">Die Bundesfinanzamtsnummer für die das Bundesland ermittelt werden soll</param>
        /// <returns><code>null</code> wenn die Bundesfinanzamtsnummer ungültig ist</returns>
        public Province? GetProvinceFor(int taxOfficeId)
        {
            var provinceId = taxOfficeId / 100;
            Province province;
            if (!_provinceIdsToProvince.TryGetValue(provinceId, out province))
                return null;
            return province;
        }

        /// <summary>
        /// Gehört die Bundesfinanzamtsnummer zu Berlin A oder Berlin B?
        /// </summary>
        /// <param name="taxOfficeId">Die zu prüfende Bundesfinanzamtsnummer</param>
        /// <param name="regionId">Die Region für Berlin</param>
        /// <returns><code>true</code> wenn die Bundesfinanzamtsnummer/<paramref name="regionId"/> zu Berlin A gehört</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public bool IsBerlinA(int taxOfficeId, int regionId)
        {
            var province = GetProvinceFor(taxOfficeId);
            if (province != Province.Berlin)
                throw new ArgumentOutOfRangeException(nameof(taxOfficeId), "Es muss eine Finanzamtsnummer für Berlin angegeben sein.");
            switch (taxOfficeId)
            {
                case 1113:
                case 1114:
                case 1117:
                case 1120:
                case 1121:
                case 1123:
                case 1124:
                case 1125:
                case 1140:
                    return regionId < 201 || regionId > 693;
                case 1127:
                case 1129:
                case 1130:
                    return true;
                case 1116:
                    return !((regionId >= 201 && regionId <= 693) || (regionId >= 1 && regionId <= 29));
                case 1119:
                    return !((regionId >= 201 && regionId <= 693) || regionId == 680 || regionId == 684);
                default:
                    return false;
            }
        }

        private class NullIsLargestComparer : IComparer<DateTime?>
        {
            public static readonly NullIsLargestComparer Default = new NullIsLargestComparer();

            public int Compare(DateTime? x, DateTime? y)
            {
                if (x == null && y == null)
                    return 0;
                if (x == null)
                    return 1;
                if (y == null)
                    return -1;
                return x.Value.CompareTo(y.Value);
            }
        }
    }
}
