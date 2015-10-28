// <copyright file="TaxOfficeInfoQueryEventArgs.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

namespace Dataline.Elster
{
    /// <summary>
    /// Argument für <see cref="TaxNumber.TaxOfficeInfoQuery"/>
    /// </summary>
    public class TaxOfficeInfoQueryEventArgs : EventArgs
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxOfficeInfoQueryEventArgs"/> Klasse.
        /// </summary>
        /// <param name="taxOfficeId">Die Bundesfinanzamtsnummer</param>
        public TaxOfficeInfoQueryEventArgs(int taxOfficeId)
            : this(taxOfficeId, false)
        {
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxOfficeInfoQueryEventArgs"/> Klasse.
        /// </summary>
        /// <param name="taxOfficeId">Die Bundesfinanzamtsnummer</param>
        /// <param name="allowTest">Ist ein Test-Finanzamt erlaubt?</param>
        public TaxOfficeInfoQueryEventArgs(int taxOfficeId, bool allowTest)
        {
            TaxOfficeId = taxOfficeId;
            AllowTest = allowTest;
        }

        /// <summary>
        /// Holt einen Wert, der angibt, ob ein Test-Finanzamt erlaubt ist
        /// </summary>
        public bool AllowTest { get; private set; }

        /// <summary>
        /// Holt die Bundesfinanzamtsnummer
        /// </summary>
        public int TaxOfficeId { get; private set; }

        /// <summary>
        /// Holt die Informationen über das Finanzamt
        /// </summary>
        public TaxOfficeInfo Info { get; set; }
    }
}
