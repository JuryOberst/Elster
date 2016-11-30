// <copyright file="eTIN.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Überprüfung der eTIN
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Die Nummer heisst wirklich eTIN.")]
    //// ReSharper disable once InconsistentNaming
    public class eTIN
    {
        /// <summary>
        /// Alle für eine eTIN gültigen Zeichen
        /// </summary>
        public const string ValidCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

        #region Prüfzifferdaten
        private static readonly Dictionary<char, int> _evenValues = new Dictionary<char, int>
        {
            { '0', 0 },
            { '1', 1 },
            { '2', 2 },
            { '3', 3 },
            { '4', 4 },
            { '5', 5 },
            { '6', 6 },
            { '7', 7 },
            { '8', 8 },
            { '9', 9 },
            { 'A', 0 },
            { 'B', 1 },
            { 'C', 2 },
            { 'D', 3 },
            { 'E', 4 },
            { 'F', 5 },
            { 'G', 6 },
            { 'H', 7 },
            { 'I', 8 },
            { 'J', 9 },
            { 'K', 10 },
            { 'L', 11 },
            { 'M', 12 },
            { 'N', 13 },
            { 'O', 14 },
            { 'P', 15 },
            { 'Q', 16 },
            { 'R', 17 },
            { 'S', 18 },
            { 'T', 19 },
            { 'U', 20 },
            { 'V', 21 },
            { 'W', 22 },
            { 'X', 23 },
            { 'Y', 24 },
            { 'Z', 25 }
        };

        private static readonly Dictionary<char, int> _oddValues = new Dictionary<char, int>
        {
            { '0', 1 },
            { '1', 0 },
            { '2', 5 },
            { '3', 7 },
            { '4', 9 },
            { '5', 13 },
            { '6', 15 },
            { '7', 17 },
            { '8', 19 },
            { '9', 21 },
            { 'A', 1 },
            { 'B', 0 },
            { 'C', 5 },
            { 'D', 7 },
            { 'E', 9 },
            { 'F', 13 },
            { 'G', 15 },
            { 'H', 17 },
            { 'I', 19 },
            { 'J', 21 },
            { 'K', 2 },
            { 'L', 4 },
            { 'M', 18 },
            { 'N', 20 },
            { 'O', 11 },
            { 'P', 3 },
            { 'Q', 6 },
            { 'R', 8 },
            { 'S', 12 },
            { 'T', 14 },
            { 'U', 16 },
            { 'V', 10 },
            { 'W', 22 },
            { 'X', 23 },
            { 'Y', 24 },
            { 'Z', 25 }
        };
        #endregion

        private static readonly Regex _etinRegex = new Regex(@"^[A-Z]{8}\d{2}[A-Z]{1}\d{2}[A-Z]{1}$");

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="eTIN"/> Klasse.
        /// </summary>
        /// <param name="value">Die zu überprüfende eTIN</param>
        public eTIN([NotNull] string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            Value = value.Replace(" ", string.Empty);
        }

        /// <summary>
        /// Holt die im Konstruktor übergebene eTIN (ohne Leerzeichen)
        /// </summary>
        [NotNull]
        public string Value { get; }

        /// <summary>
        /// Holt den Status der eTIN
        /// </summary>
        public eTINStatus Status
        {
            get
            {
                if (Value.Length != 14)
                    return eTINStatus.InvalidLength;
                if (Value.Cast<char>().Any(c => ValidCharacters.IndexOf(c) == -1))
                {
                    return eTINStatus.InvalidCharacter;
                }
                if (!_etinRegex.IsMatch(Value))
                    return eTINStatus.InvalidStructure;
                if (CheckDigit != CalculateCheckDigit())
                    return eTINStatus.CheckDigigMismatch;
                return eTINStatus.Ok;
            }
        }

        /// <summary>
        /// Holt eine Status-Meldung für den <see cref="Status"/>
        /// </summary>
        [NotNull]
        public string StausMessage
        {
            get
            {
                switch (Status)
                {
                    case eTINStatus.Ok:
                        return "Die eTIN ist korrekt";
                    case eTINStatus.CheckDigigMismatch:
                        return "Die Prüfsumme der eTIN ist fehlerhaft";
                    case eTINStatus.InvalidCharacter:
                        return "Die eTIN enhält ungültige Zeichen. Erlaubt sind nur Großbuchstaben (A-Z) und Ziffern (0-9)";
                    case eTINStatus.InvalidLength:
                        return "Die eTIN ist nicht 14 Zeichen lang";
                    case eTINStatus.InvalidStructure:
                        return "Die Struktur der eTIN ist ungültig. Die eTIN muss aus acht Buchstaben, zwei Ziffern, einem Buchstaben, zwei Ziffern und einem Buchstaben bestehen";
                    default:
                        throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Holt einen Wert, der angibt, ob die eTIN gültig ist
        /// </summary>
        public bool Valid => Status == eTINStatus.Ok;

        /// <summary>
        /// Holt die Prüfziffer von <see cref="Value"/>
        /// </summary>
        public char CheckDigit => GetNumberPart(13, 1, "X")[0];

        /// <summary>
        /// Überprüft ob die <paramref name="eTIN"/> gültig ist
        /// </summary>
        /// <param name="eTIN">Die zu überprüfende eTIN</param>
        /// <returns><code>true</code> wenn die eTIN gültig ist</returns>
        // ReSharper disable once InconsistentNaming
        public static bool IsValid(string eTIN)
        {
            return new eTIN(eTIN).Valid;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Value;
        }

        private char CalculateCheckDigit()
        {
            // vgl. http://www.pruefziffernberechnung.de/E/eTIN.shtml
            int sum = 0;
            for (int i = 0; i < (Value.Length - 1); i++)
            {
                if ((i + 1) % 2 == 0) // Für gerade/ungerade fängt der Index mit 1 an!
                    sum += _evenValues[Value[i]];
                else
                    sum += _oddValues[Value[i]];
            }

            return (char)('A' + (sum % 26));
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
