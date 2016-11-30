// <copyright file="eTINStatus.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster
{
    /// <summary>
    /// Der Status einer eTIN-Prüfung
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:Element must begin with upper-case letter", Justification = "Der Name ist wirklich eTIN")]
    //// ReSharper disable once InconsistentNaming
    public enum eTINStatus
    {
        /// <summary>
        /// Die eTIN ist gültig
        /// </summary>
        Ok,

        /// <summary>
        /// Die eTIN hat eine ungültige Länge
        /// </summary>
        /// <remarks>
        /// Eine eTIN muss genau 14 Zeichen lang sein.
        /// </remarks>
        InvalidLength,

        /// <summary>
        /// Die eTIN enthält ein ungültiges Zeichen
        /// </summary>
        /// <remarks>
        /// Nur die Zeichen in <see cref="eTIN.ValidCharacters"/> sind erlaubt.
        /// </remarks>
        InvalidCharacter,

        /// <summary>
        /// Die Struktur der eTIN ist falsch
        /// </summary>
        /// <remarks>
        /// Die eTIN muss folgenden Aufbau haben: <code>[A-Z]{8}\d{2}[A-Z]{1}\d{2}[A-Z]{1}</code>
        /// </remarks>
        InvalidStructure,

        /// <summary>
        /// Die Prüfsumme der eTIN ist falsch
        /// </summary>
        CheckDigigMismatch
    }
}
