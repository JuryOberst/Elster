// <copyright file="IdNr.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Linq;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Überprüfung der Steueridentifikationsnummer
    /// </summary>
    public partial class IdNr
    {
        /// <summary>
        /// Die für eine Steueridentifikationsnummer gültigen Zeichen
        /// </summary>
        public const string ValidCharacters = "0123456789";

        private IdNrStatus? _status;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="IdNr"/> Klasse.
        /// </summary>
        /// <param name="value">Der zu überprüfende Wert</param>
        public IdNr([NotNull] string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            Value = value.Replace(" ", string.Empty);
        }

        /// <summary>
        /// Holt den beim Konstruktor übergebenen Wert (ohne Leerzeichen)
        /// </summary>
        [NotNull]
        public string Value { get; }

        /// <summary>
        /// Holt den Status der Steueridentifikationsnummer
        /// </summary>
        public IdNrStatus Status
        {
            get
            {
                if (!_status.HasValue)
                    _status = DetermineStatus();
                return _status.Value;
            }
        }

        /// <summary>
        /// Holt eine Statusmeldung für den <see cref="Status"/>
        /// </summary>
        [NotNull]
        public string StatusMessage
        {
            get
            {
                switch (Status)
                {
                    case IdNrStatus.Ok:
                        return "Die IdNr ist korrekt.";
                    case IdNrStatus.CheckDigigMismatch:
                        return "Die Prüfsumme der IdNr ist fehlerhaft.";
                    case IdNrStatus.InvalidCharacter:
                        return "Die IdNr enhält ungültige Zeichen. Erlaubt sind nur Ziffern (0-9).";
                    case IdNrStatus.InvalidLength:
                        return "Die IdNr ist nicht 11 Zeichen lang.";
                    case IdNrStatus.InvalidStructure:
                        return "Die Struktur der IdNr ist ungültig.";
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Holt einen Wert, der angibt, ob die Steueridentifikationsnummer gültig ist.
        /// </summary>
        public bool Valid => Status == IdNrStatus.Ok;

        /// <summary>
        /// Holt die Prüfziffer der im Konstruktor übergebenen Steueridentifikationsnummer
        /// </summary>
        public int CheckDigit => Convert.ToInt32(GetNumberPart(10, 1, "0"));

        /// <summary>
        /// Holt einen Wert, der angibt, ob die Steueridentifikationsnummer eine Testnummer ist
        /// </summary>
        public bool IsTestNumber => TestValues.IsTestIdNr(Value);

        /// <summary>
        /// Prüft, ob die übergebene Steueridentifikationsnummer gültig ist
        /// </summary>
        /// <param name="idnr">Die zu prüfende Steueridentifikationsnummer</param>
        /// <returns><code>true</code> wenn die Steueridentifikationsnummer gültig ist</returns>
        public static bool IsValid(string idnr)
        {
            return new IdNr(idnr).Valid;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            if (!Valid)
                return Value;
            return $"{Value.Substring(0, 2)} {Value.Substring(2, 3)} {Value.Substring(5, 3)} {Value.Substring(8, 3)}";
        }

        private IdNrStatus DetermineStatus()
        {
            if (Value.Length != 11)
                return IdNrStatus.InvalidLength;
            var figureCount = new int[10];
            foreach (char ch in Value.Substring(0, 10))
            {
                var index = ValidCharacters.IndexOf(ch);
                if (index == -1)
                    return IdNrStatus.InvalidCharacter;
                figureCount[index] += 1;
            }

            // Nur eine Ziffer darf und muss doppelt vorhanden sein.
            // Wenn also 9 (von 11) Ziffern eindeutig sind, dann sind die beiden anderen Ziffern
            // automatisch doppelt vorhanden.
            if (figureCount.Where(x => x == 1).Count() != 8)
                return IdNrStatus.InvalidStructure;
            if (figureCount.Where(x => x == 0).Count() != 1)
                return IdNrStatus.InvalidStructure;
            if (CheckDigit != CalculateCheckDigit())
                return IdNrStatus.CheckDigigMismatch;
            return IdNrStatus.Ok;
        }

        private int CalculateCheckDigit()
        {
            // vgl. http://www1.osci.de/sixcms/media.php/13/Pr%FCfziffernberechnung.pdf
            const int n = 11;
            const int m = 10;

            var produkt = m;

            var length = Value.Length;

            for (var i = 0; i != length - 1; i++)
            {
                var ziffer = (int)char.GetNumericValue(Value, i);
                var summe = (ziffer + produkt) % m;
                if (summe == 0)
                    summe = m;
                produkt = (2 * summe) % n;
            }

            var check = n - produkt;
            if (check == 10)
                check = 0;

            return check;
        }

        [NotNull]
        private string GetNumberPart(int offset, int length, [NotNull] string defaultValue)
        {
            if (Value.Length >= (offset + length))
                return Value.Substring(offset, length);
            return defaultValue;
        }
    }
}
