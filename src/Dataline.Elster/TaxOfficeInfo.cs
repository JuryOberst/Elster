// <copyright file="TaxOfficeInfo.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Informationen über ein Finanzamt
    /// </summary>
    public class TaxOfficeInfo
    {
        [CanBeNull]
        private string _normalizedName;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxOfficeInfo" /> Klasse.
        /// </summary>
        /// <param name="bufaNr">Die BUFA-Nummer (Bundesfinanzamt-Nummer)</param>
        /// <param name="name">Name des Finanzamtes</param>
        /// <param name="supportsLsta">Dürfen Lohnsteuer-Anmeldungen hierher versandt werden?</param>
        /// <param name="province">Zu welchem Bundesland gehört das Finanzamt?</param>
        /// <param name="isTest">Ist das FA ein Test-Finanzamt?</param>
        /// <param name="validSince">Gültig seit?</param>
        /// <param name="validUntil">Gültig bis?</param>
        /// <param name="redirectTo">Neue FA-Nummer</param>
        public TaxOfficeInfo(int bufaNr, [NotNull] string name, bool supportsLsta, Province province, bool isTest = false, DateTime? validSince = null, DateTime? validUntil = null, IReadOnlyList<int> redirectTo = null)
        {
            BufaNr = bufaNr;
            Name = name.Trim();
            SupportsElsterAnmeldung = supportsLsta;
            Province = province;
            IsTest = isTest;
            ValidSince = validSince;
            ValidUntil = validUntil;
            RedirectTo = redirectTo;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxOfficeInfo" /> Klasse.
        /// </summary>
        /// <remarks>
        /// Der Name wird mit <code>Unbekannt</code> initialisiert. Dieser Konstruktor eignet
        /// sich z.B. für einen O/R-Mapper, damit dadurch auch Datenbank-Abfragen ermöglicht
        /// werden.
        /// </remarks>
        public TaxOfficeInfo()
        {
            Name = "Unbekannt";
        }

        /// <summary>
        /// Holt die Bundesfinanzamtsnummer
        /// </summary>
        public int BufaNr { get; set; }

        /// <summary>
        /// Holt den Finanzamtsnamen
        /// </summary>
        [NotNull]
        public string Name { get; set; }

        /// <summary>
        /// Holt einen Wert, der angibt, ob das Finanzamt Lohnsteueranmeldungen akzeptiert
        /// </summary>
        public bool SupportsElsterAnmeldung { get; set; }

        /// <summary>
        /// Holt das Bundesland für das das Finanzamt zuständig ist
        /// </summary>
        public Province Province { get; set; }

        /// <summary>
        /// Holt einen Wert, der angibt, ob das Finanzamt ein Test-Finanzamt ist
        /// </summary>
        public bool IsTest { get; set; }

        /// <summary>
        /// Das Datum ab dem das Finanzamt gültig ist
        /// </summary>
        public DateTime? ValidSince { get; set; }

        /// <summary>
        /// Das Datum bis zu dem das Finanzamt gültig ist
        /// </summary>
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Holt oder setzt die neue(n) FA-Nummer(n) (z.B. bei Zusammenlegungen)
        /// </summary>
        /// <remarks>
        /// Dieses FA kann trotzdem gültig sein - nur halt nicht
        /// von Aussen (<see cref="SupportsElsterAnmeldung"/> == false).
        /// </remarks>
        [CanBeNull]
        public IReadOnlyList<int> RedirectTo { get; set; }

        /// <summary>
        /// Holt den normalisierten Namen des Finanzamts
        /// </summary>
        /// <returns>Der normalisierte Name, ggf. mit <c>Finanzamt</c> am Anfang</returns>
        [NotNull]
        public string NormalizedName
        {
            get
            {
                return _normalizedName ?? (_normalizedName = GetNormalizedName());
            }
        }

        [NotNull]
        private string GetNormalizedName()
        {
            if (Name.IndexOf("Finanzamt", StringComparison.Ordinal) != -1
                || Name.IndexOf("FA", StringComparison.Ordinal) != -1
                || Name.IndexOf("hauptkasse", StringComparison.OrdinalIgnoreCase) != -1
                || Name.IndexOf("finanzkasse", StringComparison.OrdinalIgnoreCase) != -1
                || Name.IndexOf("Prüfungsstelle", StringComparison.Ordinal) != -1)
            {
                return Name;
            }

            return "Finanzamt " + Name;
        }
    }
}
