// <copyright file="TaxNumberStatus.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster
{
    /// <summary>
    /// Status der Steuernummernprüfung
    /// </summary>
    public enum TaxNumberStatus
    {
        /// <summary>
        /// Die Steuernummer ist gültig.
        /// </summary>
        Ok,

        /// <summary>
        /// Die Steuernummer muss 13 Stellen lang sein.
        /// </summary>
        InvalidLength,

        /// <summary>
        /// Die Steuernummer darf nur aus Ziffern bestehen.
        /// </summary>
        InvalidCharacter,

        /// <summary>
        /// Ungültiger Aufbau der Steuernummer.
        /// </summary>
        /// <remarks>
        /// - Die 5. Stelle der Nummer muss eine 0 sein.
        /// - In Bayern ist die Kombination von Bezirksnummer=="999", Unterscheidungsnummer="9999" und Prüfziffer="9" nicht erlaubt.
        /// - In NRW muss UUUP größer als 9 sein.
        /// </remarks>
        InvalidStructure,

        /// <summary>
        /// Ungültiges Finanzamt
        /// </summary>
        InvalidTaxOffice,

        /// <summary>
        /// Der Bezirk darf nicht 0, 998 oder 999 sein.
        /// </summary>
        InvalidRegion,

        /// <summary>
        /// Im bayerischen Programmierverbund darf die Bezirksnummer nicht kleiner als 100 sein.
        /// </summary>
        InvalidRegionId,

        /// <summary>
        /// Abweichende Prüfsumme
        /// </summary>
        CheckDigitMismatch,
    }
}
