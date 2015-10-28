// <copyright file="ITaxOfficeProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Linq;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Abfrage-Schnittstelle für Finanzamtsanbieter
    /// </summary>
    public interface ITaxOfficeProvider
    {
        /// <summary>
        /// Abfragbare Finanzämter abrufen
        /// </summary>
        /// <param name="validFor">Nur die Finanzämter, die zu diesem Zeitpunkt gültig waren</param>
        /// <returns>Abfrage für Finanzämter</returns>
        [NotNull, ItemNotNull]
        IQueryable<TaxOfficeInfo> Query(DateTime? validFor = null);
    }
}
