// <copyright file="TaxOfficeChangeType.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster
{
    /// <summary>
    /// Die Art der Änderung der statischen FA-Liste
    /// </summary>
    internal enum TaxOfficeChangeType
    {
        /// <summary>
        /// Gültigkeit eines Finanzamts hat sich geändert
        /// </summary>
        ChangeValid,

        /// <summary>
        /// Der Name hat sich geändert
        /// </summary>
        ChangeName,

        /// <summary>
        /// Ein Finanzamt wurde gegründet
        /// </summary>
        New,

        /// <summary>
        /// Die Lohnsteueranmeldungen eines Finanzamts müssen umgeleitet werden
        /// </summary>
        RedirectTo,
    }
}
