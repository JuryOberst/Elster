// <copyright file="TaxOfficesExtensions.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Erweiterungsfunktionen für <see cref="TaxOfficeInfo"/>
    /// </summary>
    public static class TaxOfficesExtensions
    {
        /// <summary>
        /// Filterung der Finanzämter nach Gültigkeitsdatum
        /// </summary>
        /// <param name="taxOffices">Die zu filternden Finanzämter</param>
        /// <param name="validFor">Das Datum an dem die Finanzämter gültig sein müssen</param>
        /// <returns>Die gefilterten Finanzämter</returns>
        [NotNull, ItemNotNull]
        public static IEnumerable<TaxOfficeInfo> ValidFor([NotNull, ItemNotNull] this IEnumerable<TaxOfficeInfo> taxOffices, DateTime? validFor)
        {
            if (!validFor.HasValue)
                return taxOffices;
            var date = validFor.Value.Date;
            taxOffices = taxOffices.Where(x =>
                (x.ValidSince == null && x.ValidUntil == null)
                || (x.ValidSince == null && x.ValidUntil != null && x.ValidUntil.Value > date)
                || (x.ValidUntil == null && x.ValidSince != null && x.ValidSince.Value <= date)
                || (x.ValidSince != null && x.ValidSince.Value <= date && x.ValidUntil != null && x.ValidUntil.Value > date));
            return taxOffices;
        }

        /// <summary>
        /// Filterung der Finanzämter nach Gültigkeitsdatum
        /// </summary>
        /// <param name="taxOffices">Die zu filternden Finanzämter</param>
        /// <param name="validFor">Das Datum an dem die Finanzämter gültig sein müssen</param>
        /// <returns>Die gefilterten Finanzämter</returns>
        [NotNull, ItemNotNull]
        public static IQueryable<TaxOfficeInfo> ValidFor([NotNull, ItemNotNull] this IQueryable<TaxOfficeInfo> taxOffices, DateTime? validFor)
        {
            if (!validFor.HasValue)
                return taxOffices;
            var date = validFor.Value.Date;
            taxOffices = taxOffices.Where(x =>
                (x.ValidSince == null && x.ValidUntil == null)
                || (x.ValidSince == null && x.ValidUntil != null && x.ValidUntil.Value > date)
                || (x.ValidUntil == null && x.ValidSince != null && x.ValidSince.Value <= date)
                || (x.ValidSince != null && x.ValidSince.Value <= date && x.ValidUntil != null && x.ValidUntil.Value > date));
            return taxOffices;
        }
    }
}
