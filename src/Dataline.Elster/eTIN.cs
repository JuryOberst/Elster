// <copyright file="eTIN.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
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

        /// <summary>
        /// Alle für den Namen gültigen Zeichen
        /// </summary>
        private const string ValidNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

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

        /// <summary>
        /// Diese Tabelle enthaelt die zu ersetzenden Zeichen
        /// </summary>
        private static readonly IReadOnlyDictionary<char, string> _replacementCharacters =
            new List<Tuple<char, string>>()
                {
                    Tuple.Create('À', "A"),
                    Tuple.Create('Á', "A"),
                    Tuple.Create('Â', "A"),
                    Tuple.Create('Ã', "A"),
                    Tuple.Create('Å', "A"),
                    Tuple.Create('à', "A"),
                    Tuple.Create('á', "A"),
                    Tuple.Create('â', "A"),
                    Tuple.Create('ã', "A"),
                    Tuple.Create('å', "A"),
                    Tuple.Create('Ä', "AE"),
                    Tuple.Create('ä', "AE"),
                    Tuple.Create('Æ', "AE"),
                    Tuple.Create('æ', "AE"),
                    Tuple.Create('ç', "C"),
                    Tuple.Create('Ç', "C"),
                    Tuple.Create('Ð', "D"),
                    Tuple.Create('ð', "D"),
                    Tuple.Create('È', "E"),
                    Tuple.Create('É', "E"),
                    Tuple.Create('Ê', "E"),
                    Tuple.Create('Ë', "E"),
                    Tuple.Create('è', "E"),
                    Tuple.Create('é', "E"),
                    Tuple.Create('ê', "E"),
                    Tuple.Create('ë', "E"),
                    Tuple.Create('Ì', "I"),
                    Tuple.Create('Í', "I"),
                    Tuple.Create('Î', "I"),
                    Tuple.Create('Ï', "I"),
                    Tuple.Create('ì', "I"),
                    Tuple.Create('í', "I"),
                    Tuple.Create('î', "I"),
                    Tuple.Create('ï', "I"),
                    Tuple.Create('Ñ', "N"),
                    Tuple.Create('ñ', "N"),
                    Tuple.Create('Ò', "O"),
                    Tuple.Create('Ó', "O"),
                    Tuple.Create('Ô', "O"),
                    Tuple.Create('Õ', "O"),
                    Tuple.Create('Ö', "OE"),
                    Tuple.Create('Ø', "O"),
                    Tuple.Create('ò', "O"),
                    Tuple.Create('ó', "O"),
                    Tuple.Create('ô', "O"),
                    Tuple.Create('õ', "O"),
                    Tuple.Create('ö', "OE"),
                    Tuple.Create('ø', "O"),
                    Tuple.Create('Š', "S"),
                    Tuple.Create('š', "S"),
                    Tuple.Create('Ù', "U"),
                    Tuple.Create('Ú', "U"),
                    Tuple.Create('Û', "U"),
                    Tuple.Create('ù', "U"),
                    Tuple.Create('ú', "U"),
                    Tuple.Create('û', "U"),
                    Tuple.Create('Ü', "UE"),
                    Tuple.Create('ü', "UE"),
                    Tuple.Create('Ÿ', "Y"),
                    Tuple.Create('Ý', "Y"),
                    Tuple.Create('ý', "Y"),
                    Tuple.Create('ÿ', "Y"),
                    Tuple.Create('Ž', "Z"),
                    Tuple.Create('ž', "Z"),
                    Tuple.Create('ß', "SS"),
                }
                .Concat(ValidNameCharacters.ToCharArray().Select(ch => Tuple.Create(ch, char.ToUpper(ch).ToString())))
                .ToDictionary(x => x.Item1, x => x.Item2);

        /// <summary>
        /// Hier werden nur die Vokale gespeichert
        /// </summary>
        private static readonly ISet<char> _vowels = new HashSet<char>(new[] { 'A', 'E', 'I', 'O', 'U' });

        /// <summary>
        /// Liste der Buchstaben, die einem Monat entsprechen (A = Januar, B = Februar, etc...)
        /// </summary>
        private static readonly string _monthCharacters = "ABCDEFGHIJKL";

        /// <summary>
        /// Struktur einer gültigen eTIN
        /// </summary>
        private static readonly Regex _etinRegex = new Regex(@"^[A-Z]{8}\d{2}[A-L](([0-2][0-9])|(3[01]))[A-Z]$");

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
                if (CheckDigit != CalculateCheckDigit(Value.Substring(0, Value.Length - 1)))
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

        /// <summary>
        /// Erstellt eine eTIN anhand des Nachnamens, Vornamens und des Geburtstages
        /// </summary>
        /// <param name="surname">Nachname</param>
        /// <param name="forename">Vorname</param>
        /// <param name="dateOfBirth">Geburtstag</param>
        /// <returns>Die errechnete eTIN</returns>
        public static string Create(string surname, string forename, DateTime dateOfBirth)
        {
            var birthdayCode = $"{dateOfBirth.Year % 100:D2}{_monthCharacters[dateOfBirth.Month - 1]}{dateOfBirth.Day:D2}";
            var stringToCheckSum = GetFourCharacters(surname) + GetFourCharacters(forename) + birthdayCode;
            return stringToCheckSum + CalculateCheckDigit(stringToCheckSum);
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Value;
        }

        /// <summary>
        /// String normalisieren
        /// </summary>
        /// <remarks>
        /// Alle unbekannten Zeichen werden entfernt und Umlaute werden durch "normale" Zeichen ersetzt.
        /// </remarks>
        /// <param name="s">Der zu normalisierende String</param>
        /// <returns>Der normalisierte String</returns>
        private static string NormalizeString(string s)
        {
            var result = new StringBuilder();

            foreach (var ch in s)
            {
                string replaceText;
                if (_replacementCharacters.TryGetValue(ch, out replaceText))
                    result.Append(replaceText);
            }

            return result.ToString();
        }

        /// <summary>
        /// Erzeugt aus einem String wie z.B. Nachname die lt. Anforderung benoetigten 4 Zeichen zum Aufbau der eTIN
        /// </summary>
        /// <param name="str">Ein String aus dem die 4 Zeichen zum eTIN-Aufbau ermittelt werden</param>
        /// <returns>Die 4 Zeichen zum eTIN-Aufbau ermittelt wurden</returns>
        private static string GetFourCharacters(string str)
        {
            var erg = new StringBuilder();

            // Zuerst einmal alle Sonderzeichen umwandeln bzw. ersetzen
            var s = NormalizeString(str);

            // Jedes SCH durch 'Y' ersetzen, lt. Anforderung
            s = s.Replace("SCH", "Y");

            // Die Konsonanten von links nach rechts aufbauen,
            // wobei maximal 4 benoetigt werden
            for (var i = 0; i < s.Length && erg.Length < 4; i++)
            {
                if (!_vowels.Contains(s[i]))
                {
                    erg.Append(s[i]);
                }
            }

            if (erg.Length < 4)
            {
                // Wenn nicht mehr genuegend Konsonanten zur Verfuegung standen,
                // dann den Rest mit Vokalen auffuellen, die von der Zeichenkette
                // von rechts nach links ermittelt werden
                for (var i = s.Length - 1; i >= 0 && erg.Length < 4; i--)
                {
                    if (_vowels.Contains(s[i]))
                    {
                        erg.Append(s[i]);
                    }
                }

                // Wenn auch dann immer noch keine 4 Zeichen zusammengekommen sind,
                // dann den Rest mit 'X' auffuellen
                while (erg.Length < 4)
                {
                    erg.Append("X");
                }
            }

            return erg.ToString();
        }

        private static char CalculateCheckDigit(string value)
        {
            // vgl. http://www.pruefziffernberechnung.de/E/eTIN.shtml
            int sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                if ((i + 1) % 2 == 0) // Für gerade/ungerade fängt der Index mit 1 an!
                    sum += _evenValues[value[i]];
                else
                    sum += _oddValues[value[i]];
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
