// <copyright file="TestIdNrQueryEventArgs.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Argumente für <see cref="Elster.IdNr.TestValues.TestIdNrQuery"/>
    /// </summary>
    public class TestIdNrQueryEventArgs : EventArgs
    {
        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TestIdNrQueryEventArgs"/> Klasse.
        /// </summary>
        /// <param name="idnr">Die zu überprüfende Steueridentifikationsnummer</param>
        public TestIdNrQueryEventArgs([NotNull] string idnr)
        {
            IdNr = idnr;
            IsTestIdNr = false;
        }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob die Steueridentifikationsnummer eine Test-Nummer ist
        /// </summary>
        public bool IsTestIdNr { get; set; }

        /// <summary>
        /// Holt die zu überprüfende Steueridentifikationsnummer
        /// </summary>
        [NotNull]
        public string IdNr { get; }
    }
}
