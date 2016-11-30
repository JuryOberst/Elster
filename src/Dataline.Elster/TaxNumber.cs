// <copyright file="TaxNumber.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

using JetBrains.Annotations;

namespace Dataline.Elster
{
    /// <summary>
    /// Überprüfung einer Steuernummer
    /// </summary>
    public class TaxNumber
    {
        /// <summary>
        /// Die in einer Steuernummer gültigen Zeichen
        /// </summary>
        public static readonly string ValidCharacters = "0123456789";

        private static readonly IReadOnlyList<int> _checkDigitFactorsVariant1 = new[]
        {
            0, 5, 4, 3, 0, 2, 7, 6, 5, 4, 3, 2
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsVariant2 = new[]
        {
            0, 0, 4, 3, 0, 2, 7, 6, 5, 4, 3, 2
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsVariant3 = new[]
        {
            0, 0, 1, 2, 0, 1, 2, 1, 2, 1, 2, 1
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsVariant4 = new[]
        {
            0, 0, 2, 9, 0, 8, 7, 6, 5, 4, 3, 2
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsVariant5 = new[]
        {
            0, 3, 2, 1, 0, 7, 6, 5, 4, 3, 2, 1
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsVariant6 = new[]
        {
            0, 0, 512, 256, 0, 128, 64, 32, 16, 8, 4, 2
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsBerlinA = new[]
        {
            0, 0, 0, 0, 0, 7, 6, 5, 8, 4, 3, 2
        };

        private static readonly IReadOnlyList<int> _checkDigitFactorsBerlinB = new[]
        {
            0, 0, 2, 9, 0, 8, 7, 6, 5, 4, 3, 2
        };

        private static readonly IReadOnlyList<int> _checkDigitSummandVariant1 = new[]
        {
            0, 0, 9, 8, 0, 7, 6, 5, 4, 3, 2, 1
        };

        private static readonly IReadOnlyList<int> _checkDigitSummandVariant2 = new[]
        {
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
        };

        private Province? _province;

        private TaxNumberStatus? _status;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxNumber"/> Klasse
        /// </summary>
        /// <param name="number">Die zu überprüfende Steuernummer</param>
        public TaxNumber([NotNull] string number)
            : this(TaxOffices.Active, number)
        {
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxNumber"/> Klasse
        /// </summary>
        /// <param name="number">Die zu überprüfende Steuernummer</param>
        /// <param name="province">Das Bundesland für eine bundeslandspezifische Steuernummer</param>
        public TaxNumber([NotNull] string number, Province province)
            : this(TaxOffices.Active, number, province)
        {
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxNumber"/> Klasse
        /// </summary>
        /// <param name="taxOffices">Die Finanzämter die zur Prüfung herangezogen werden</param>
        /// <param name="number">Die zu überprüfende Steuernummer</param>
        public TaxNumber([NotNull] TaxOffices taxOffices, [NotNull] string number)
            : this(taxOffices, number, null)
        {
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="TaxNumber"/> Klasse
        /// </summary>
        /// <param name="taxOffices">Die Finanzämter die zur Prüfung herangezogen werden</param>
        /// <param name="number">Die zu überprüfende Steuernummer</param>
        /// <param name="province">Das Bundesland für eine bundeslandspezifische Steuernummer</param>
        public TaxNumber([NotNull] TaxOffices taxOffices, [NotNull] string number, Province province)
            : this(taxOffices, number, (Province?)province)
        {
        }

        private TaxNumber([NotNull] TaxOffices taxOffices, [NotNull] string number, Province? province)
            : this(taxOffices, TryParseNumber(number, province))
        {
        }

        private TaxNumber([NotNull] TaxOffices taxOffices, [NotNull] ParseResult parseResult)
        {
            if (taxOffices == null)
                throw new ArgumentNullException(nameof(taxOffices));
            TaxOffices = taxOffices;
            _province = parseResult.Province;
            _status = parseResult.Status;
            Number = parseResult.TaxNumber;
        }

        private delegate int CalculateCheckDigitDelegate([NotNull] IReadOnlyList<int> summand, [NotNull] IReadOnlyList<int> factors);

        /// <summary>
        /// Dieses Event wird ausgelöst, wenn nach einem Finanzamt gesucht werden soll.
        /// </summary>
        /// <remarks>
        /// Wenn dieses Event kein Finanzamt zurückliefert, dann werden die Finanzämter über <see cref="TaxOffices"/> gesucht.
        /// </remarks>
        public event EventHandler<TaxOfficeInfoQueryEventArgs> TaxOfficeInfoQuery;

        /// <summary>
        /// Die Finanzämter die zum Einlesen und Überprüfen herangezogen werden
        /// </summary>
        [NotNull]
        public TaxOffices TaxOffices { get; }

        /// <summary>
        /// Holt oder setzt einen Wert, der angibt, ob Test-Finanzämter als Gültig betrachtet werden
        /// </summary>
        public bool AllowTestTaxOffices { get; set; }

        /// <summary>
        /// Holt die ELSTER-Steuernummer oder die ungültige Steuernummer
        /// </summary>
        /// <remarks>
        /// Die bundeslandspezifische Steuernummer kann über <see cref="ToString()"/> abgefragt werden.
        /// Wenn die geprüfte Steuernummer ungültig war, dann ist hierüber nicht die ELSTER-Steuernummer
        /// abfragbar, sondern die fehlerhafte Steuernummer.
        /// </remarks>
        [NotNull]
        public string Number { get; }

        /// <summary>
        /// Holt die Bundesfinanzamtsnummer (FFFF)
        /// </summary>
        public int FederalTaxOfficeId
        {
            get
            {
                try
                {
                    return Convert.ToInt32(GetNumberPart(0, 4, "0"), 10);
                }
                catch
                {
                    // Wenn in den Original-Daten Müll steht, dann wirft Convert.ToInt32 eine Exception
                    return 0;
                }
            }
        }

        /// <summary>
        /// Holt die Bereichsnummer (BBB oder BBBB (NRW))
        /// </summary>
        public int RegionId
        {
            get
            {
                try
                {
                    string regionId = (Province == Elster.Province.NordrheinWestfalen) ? GetNumberPart(5, 4, "0") : GetNumberPart(5, 3, "0");
                    return Convert.ToInt32(regionId, 10);
                }
                catch
                {
                    // Wenn in den Original-Daten Müll steht, dann wirft Convert.ToInt32 eine Exception
                    return 0;
                }
            }
        }

        /// <summary>
        /// Holt die Unterscheidungsnummer (UUUU oder UUU (NRW))
        /// </summary>
        public int DeterminationId
        {
            get
            {
                try
                {
                    var determinationId = (Province == Elster.Province.NordrheinWestfalen) ? GetNumberPart(9, 3, "0") : GetNumberPart(8, 4, "0");
                    return Convert.ToInt32(determinationId, 10);
                }
                catch
                {
                    // Wenn in den Original-Daten Müll steht, dann wirft Convert.ToInt32 eine Exception
                    return 0;
                }
            }
        }

        /// <summary>
        /// Holt das Bundesland, wenn eines erkannt wurde
        /// </summary>
        public Province? Province => _province ?? (_province = GetProvinceForTaxOfficeId());

        /// <summary>
        /// Holt die Prüfziffer aus <see cref="Number"/>
        /// </summary>
        public int CheckDigit => Convert.ToInt32(GetNumberPart(12, 1, "0"));

        /// <summary>
        /// Holt das Trennzeichen für die bundeslandspezifische Steuernummer
        /// </summary>
        public char SpacingCharacterForProvince
        {
            get
            {
                char result;
                switch (Province)
                {
                    case Elster.Province.BadenWuerttemberg:
                    case Elster.Province.Bayern:
                    case Elster.Province.Brandenburg:
                    case Elster.Province.MecklenburgVorpommern:
                    case Elster.Province.Saarland:
                    case Elster.Province.Sachsen:
                    case Elster.Province.SachsenAnhalt:
                    case Elster.Province.Thueringen:
                    case Elster.Province.Berlin:
                    case Elster.Province.Hamburg:
                    case Elster.Province.Niedersachsen:
                    case Elster.Province.RheinlandPfalz:
                    case Elster.Province.NordrheinWestfalen:
                    case Elster.Province.SchleswigHolstein:
                        result = '/';
                        break;
                    default:
                        // Bremen und Hessen
                        result = ' ';
                        break;
                }
                return result;
            }
        }

        /// <summary>
        /// Liefert einen Wert, der angibt, ob die Steuernummer gültig ist
        /// </summary>
        public bool Valid => Status == TaxNumberStatus.Ok;

        /// <summary>
        /// Holt den Status der Überprüfung der Steuernummer
        /// </summary>
        public TaxNumberStatus Status => _status ?? (TaxNumberStatus)(_status = DetermineStatus());

        /// <summary>
        /// Holt die Statusmeldung zum <see cref="Status"/>
        /// </summary>
        public string StatusMessage
        {
            get
            {
                string result;
                switch (Status)
                {
                    case TaxNumberStatus.InvalidLength:
                        result = "Die Steuernummer muss 13 Stellen lang sein.";
                        break;
                    case TaxNumberStatus.InvalidCharacter:
                        result = "Die Steuernummer enthält ungültige Zeichen. Erlaubt sind nur die Ziffern 0-9.";
                        break;
                    case TaxNumberStatus.InvalidStructure:
                        result = "Der Aufbau der Steuernummer ist fehlerhaft (Zahlendreher?).";
                        break;
                    case TaxNumberStatus.InvalidTaxOffice:
                        result = "Fehlerhafte Steuernummer: Unbekannte Finanzamtnummer.";
                        break;
                    case TaxNumberStatus.InvalidRegionId:
                        result = "Fehlerhafte Steuernummer: Ungültige Bereichsnummer.";
                        break;
                    case TaxNumberStatus.InvalidRegion:
                        result = "Fehlerhafte Steuernummer: Die Bereichsnummer darf nicht 0 sein.";
                        break;
                    case TaxNumberStatus.CheckDigitMismatch:
                        result = "Die Prüfsumme der Steuernummer ist fehlerhaft.";
                        break;
                    case TaxNumberStatus.Ok:
                        result = "Die Steuernummer ist korrekt.";
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                return result;
            }
        }

        [NotNull]
        private CalculateCheckDigitDelegate CalculateCheckDigitMethod
        {
            get
            {
                switch (Province)
                {
                    case Elster.Province.BadenWuerttemberg:
                    case Elster.Province.Hessen:
                    case Elster.Province.SchleswigHolstein:
                        return CalculateCheckDigit2;
                    case Elster.Province.RheinlandPfalz:
                        return CalculateCheckDigitModified11;
                    case Elster.Province.NordrheinWestfalen:
                        // NRW macht hier mal wieder was anderes :(
                        return CalculateCheckDigitNrw11;
                    default:
                        return CalculateCheckDigit11;
                }
            }
        }

        /// <summary>
        /// Holt einen Wert, der angibt, ob die Bezirksnummer kleiner als 100 sein darf.
        /// </summary>
        private bool IsRegionAllowedToBeBelow100 => !IsBavarianProgrammingCommunity;

        /// <summary>
        /// Holt einen Wert, der angibt, ob das Bundesland zum Bayerischen Programmierverbund gehört.
        /// </summary>
        private bool IsBavarianProgrammingCommunity
        {
            get
            {
                switch (Province)
                {
                    case Elster.Province.Bayern:
                    case Elster.Province.Brandenburg:
                    case Elster.Province.MecklenburgVorpommern:
                    case Elster.Province.Saarland:
                    case Elster.Province.Sachsen:
                    case Elster.Province.SachsenAnhalt:
                    case Elster.Province.Thueringen:
                        return true;
                    default:
                        return false;
                }
            }
        }

        /// <summary>
        /// Liest die Steuernummer ein und prüft diese.
        /// </summary>
        /// <param name="taxNumber">Die einzulesende und prüfende Steuernummer</param>
        /// <param name="province">Das Bundesland der Steuernummer</param>
        /// <returns>Eine neue Instanz der <see cref="TaxNumber"/>-Klasse</returns>
        [NotNull]
        public static TaxNumber Parse([NotNull] string taxNumber, Province province)
        {
            return Parse(TaxOffices.Active, taxNumber, province);
        }

        /// <summary>
        /// Liest die Steuernummer ein und prüft diese.
        /// </summary>
        /// <param name="taxOffices">Die gültigen Finanzämter die zur Überprüfung herangezogen werden</param>
        /// <param name="taxNumber">Die einzulesende und prüfende Steuernummer</param>
        /// <param name="province">Das Bundesland der Steuernummer</param>
        /// <returns>Eine neue Instanz der <see cref="TaxNumber"/>-Klasse</returns>
        [NotNull]
        public static TaxNumber Parse([NotNull] TaxOffices taxOffices, [NotNull] string taxNumber, Province province)
        {
            var parseResult = ParseNumber(taxNumber, province);
            return new TaxNumber(taxOffices, parseResult);
        }

        /// <summary>
        /// Überprüft ob die ELSTER-Steuernummer gültig ist
        /// </summary>
        /// <param name="taxNumber">Die zu überprüfende ELSTER-Steuernummer</param>
        /// <returns><code>true</code> wenn die Steuernummer gültig ist</returns>
        /// <remarks>Dieser Aufruf funktioniert nur für die ELSTER-Steuernummer, nicht für die bundeslandspezifische Steuernummer</remarks>
        public static bool IsValid([NotNull] string taxNumber)
        {
            return IsValid(TaxOffices.Active, taxNumber);
        }

        /// <summary>
        /// Überprüft ob die bundeslandspezifische Steuernummer gültig ist
        /// </summary>
        /// <param name="taxNumber">Die zu überprüfende bundeslandspezifische Steuernummer</param>
        /// <param name="province">Das Bundesland für die bundeslandspezifische Steuernummer</param>
        /// <returns><code>true</code> wenn die bundeslandspezifische Steuernummer gültig ist</returns>
        public static bool IsValid([NotNull] string taxNumber, Province province)
        {
            return IsValid(TaxOffices.Active, taxNumber, province);
        }

        /// <summary>
        /// Überprüft ob die ELSTER-Steuernummer gültig ist
        /// </summary>
        /// <param name="taxOffices">Die Finanzämter die zur Prüfung herangezogen werden</param>
        /// <param name="taxNumber">Die zu überprüfende ELSTER-Steuernummer</param>
        /// <returns><code>true</code> wenn die Steuernummer gültig ist</returns>
        /// <remarks>Dieser Aufruf funktioniert nur für die ELSTER-Steuernummer, nicht für die bundeslandspezifische Steuernummer</remarks>
        public static bool IsValid([NotNull] TaxOffices taxOffices, [NotNull] string taxNumber)
        {
            return new TaxNumber(taxOffices, taxNumber, null).Valid;
        }

        /// <summary>
        /// Überprüft ob die bundeslandspezifische Steuernummer gültig ist
        /// </summary>
        /// <param name="taxOffices">Die Finanzämter die zur Prüfung herangezogen werden</param>
        /// <param name="taxNumber">Die zu überprüfende bundeslandspezifische Steuernummer</param>
        /// <param name="province">Das Bundesland für die bundeslandspezifische Steuernummer</param>
        /// <returns><code>true</code> wenn die bundeslandspezifische Steuernummer gültig ist</returns>
        public static bool IsValid([NotNull] TaxOffices taxOffices, [NotNull] string taxNumber, Province province)
        {
            return new TaxNumber(taxOffices, taxNumber, province).Valid;
        }

        /// <summary>
        /// Liefert die bundeslandspezifische Steuernummer
        /// </summary>
        /// <param name="spacingCharacter">Das zu verwendende Trennzeichen</param>
        /// <returns>Die bundeslandspezifische Steuernummer</returns>
        /// <remarks>
        /// Wenn die Steuernummer ungültig ist, dann wird die ursprüngliche Steuernummer zurückgeliefert.
        /// </remarks>
        [NotNull]
        public virtual string ToString(char spacingCharacter)
        {
            string result;
            if (!Valid)
            {
                result = Number;
            }
            else
            {
                switch (Province)
                {
                    case Elster.Province.BadenWuerttemberg:
                        // FFBBB/UUUUP
                        result = string.Format("{0:D02}{1:D03}{4}{2:D04}{3}", FederalTaxOfficeId % 100, RegionId, DeterminationId, CheckDigit, spacingCharacter);
                        break;
                    case Elster.Province.Bayern:
                    case Elster.Province.Brandenburg:
                    case Elster.Province.MecklenburgVorpommern:
                    case Elster.Province.Saarland:
                    case Elster.Province.Sachsen:
                    case Elster.Province.SachsenAnhalt:
                    case Elster.Province.Thueringen:
                        // FFF/BBB/UUUUP
                        result = string.Format("{0:D03}{4}{1:D03}{4}{2:D04}{3}", FederalTaxOfficeId % 1000, RegionId, DeterminationId, CheckDigit, spacingCharacter);
                        break;
                    case Elster.Province.Berlin:
                    case Elster.Province.Hamburg:
                    case Elster.Province.Niedersachsen:
                    case Elster.Province.RheinlandPfalz:
                        // FF/BBB/UUUUP
                        result = string.Format("{0:D02}{4}{1:D03}{4}{2:D04}{3}", FederalTaxOfficeId % 100, RegionId, DeterminationId, CheckDigit, spacingCharacter);
                        break;
                    case Elster.Province.Bremen:
                    case Elster.Province.SchleswigHolstein:
                        // FF BBB UUUUP
                        result = string.Format("{0:D02}{4}{1:D03}{4}{2:D04}{3}", FederalTaxOfficeId % 100, RegionId, DeterminationId, CheckDigit, spacingCharacter);
                        break;
                    case Elster.Province.Hessen:
                        // 0FF BBB UUUUP
                        result = string.Format("{0:D03}{4}{1:D03}{4}{2:D04}{3}", FederalTaxOfficeId % 100, RegionId, DeterminationId, CheckDigit, spacingCharacter);
                        break;
                    case Elster.Province.NordrheinWestfalen:
                        // FFF/BBBB/UUUP
                        result = string.Format("{0:D03}{4}{1:D04}{4}{2:D03}{3}", FederalTaxOfficeId % 1000, RegionId, DeterminationId, CheckDigit, spacingCharacter);
                        break;
                    default:
                        result = Number;
                        break;
                }
            }

            return result;
        }

        /// <summary>
        /// Liefert die bundeslandspezifische Steuernummer
        /// </summary>
        /// <returns>Die bundeslandspezifische Steuernummer</returns>
        /// <remarks>
        /// Wenn die Steuernummer ungültig ist, dann wird die ursprüngliche Steuernummer zurückgeliefert.
        /// </remarks>
        public override string ToString()
        {
            return ToString(SpacingCharacterForProvince);
        }

        /// <summary>
        /// Wird aufgerufen, wenn das Event <see cref="TaxOfficeInfoQuery"/> ausgelöst werden soll
        /// </summary>
        /// <param name="taxOfficeId">Die Finanzamtsnummer für die Informationen erfragt werden sollen</param>
        /// <param name="allowTest"><code>true</code> wenn auch Informationen über Test-Finanzämter zurückgeliefert werden sollen</param>
        /// <returns>Die gefundenen Finanzamtsinformationen</returns>
        [CanBeNull]
        protected TaxOfficeInfo OnTaxOfficeInfoQuery(int taxOfficeId, bool allowTest)
        {
            var ev = new TaxOfficeInfoQueryEventArgs(taxOfficeId, allowTest);
            TaxOfficeInfoQuery?.Invoke(this, ev);
            return ev.Info;
        }

        /// <summary>
        /// Abfrage der Informationen über ein Finanzamt
        /// </summary>
        /// <param name="taxOfficeId">Die Finanzamtsnummer für die Informationen erfragt werden sollen</param>
        /// <param name="allowTest"><code>true</code> wenn auch Informationen über Test-Finanzämter zurückgeliefert werden sollen</param>
        /// <returns>Die gefundenen Finanzamtsinformationen</returns>
        [CanBeNull]
        protected TaxOfficeInfo GetTaxOfficeInfo(int taxOfficeId, bool allowTest)
        {
            var result = OnTaxOfficeInfoQuery(taxOfficeId, allowTest)
                ?? TaxOffices.Load(taxOfficeId).FirstOrDefault();
            if (result != null && result.IsTest && !allowTest)
                result = null;
            return result;
        }

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("StyleCopPlus.StyleCopPlusRules", "SP0100:AdvancedNamingRules", Justification = "FFBBBUUUUP is the structure of the number.")]
        [NotNull]
        private static ParseResult ParseNumberFFBBBUUUUP([NotNull] string number, [NotNull] string originalNumber, Province province)
        {
            if (number.Length != 10)
                return ParseResult.AsError(originalNumber, province, TaxNumberStatus.InvalidLength);

            string prefix;
            switch (province)
            {
                case Elster.Province.Berlin:
                    prefix = "11";
                    break;
                case Elster.Province.Hamburg:
                    prefix = "22";
                    break;
                case Elster.Province.RheinlandPfalz:
                    prefix = "27";
                    break;
                case Elster.Province.BadenWuerttemberg:
                    prefix = "28";
                    break;
                case Elster.Province.Bremen:
                    prefix = "24";
                    break;
                case Elster.Province.Niedersachsen:
                    prefix = "23";
                    break;
                case Elster.Province.SchleswigHolstein:
                    prefix = "21";
                    break;
                default:
                    throw new NotSupportedException($"Kein Präfix für das Bundesland {province} hinterlegt");
            }

            var result = string.Format(
                "{4}{0}0{1}{2}{3}",
                number.Substring(0, 2),
                number.Substring(2, 3),
                number.Substring(5, 4),
                number.Substring(9, 1),
                prefix);

            return ParseResult.AsSuccess(result, province);
        }

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("StyleCopPlus.StyleCopPlusRules", "SP0100:AdvancedNamingRules", Justification = "FFFBBBUUUUP is the structure of the number.")]
        [NotNull]
        private static ParseResult ParseNumberFFFBBBUUUUP([NotNull] string number, [NotNull] string originalNumber, Province province)
        {
            if (number.Length != 11)
                return ParseResult.AsError(originalNumber, province, TaxNumberStatus.InvalidLength);

            string prefix;
            switch (province)
            {
                case Elster.Province.Bayern:
                    prefix = "9";
                    break;
                case Elster.Province.Brandenburg:
                case Elster.Province.Sachsen:
                case Elster.Province.SachsenAnhalt:
                    prefix = "3";
                    break;
                case Elster.Province.MecklenburgVorpommern:
                case Elster.Province.Thueringen:
                    prefix = "4";
                    break;
                case Elster.Province.Saarland:
                    prefix = "1";
                    break;
                default:
                    throw new NotSupportedException($"Kein Präfix für das Bundesland {province} hinterlegt");
            }

            var result = string.Format(
                "{4}{0}0{1}{2}{3}",
                number.Substring(0, 3),
                number.Substring(3, 3),
                number.Substring(6, 4),
                number.Substring(10, 1),
                prefix);

            return ParseResult.AsSuccess(result, province);
        }

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("StyleCopPlus.StyleCopPlusRules", "SP0100:AdvancedNamingRules", Justification = "FFFBBBBUUUP is the structure of the number.")]
        [NotNull]
        private static ParseResult ParseNumberFFFBBBBUUUP([NotNull] string number, [NotNull] string originalNumber, Province province)
        {
            if (number.Length != 11)
                return ParseResult.AsError(originalNumber, province, TaxNumberStatus.InvalidLength);
            const string prefix = "5";
            var result = string.Format(
                "{4}{0}0{1}{2}{3}",
                number.Substring(0, 3),
                number.Substring(3, 3),
                number.Substring(6, 4),
                number.Substring(10, 1),
                prefix);
            return ParseResult.AsSuccess(result, province);
        }

        // ReSharper disable once InconsistentNaming
        [SuppressMessage("StyleCopPlus.StyleCopPlusRules", "SP0100:AdvancedNamingRules", Justification = "FFFBBBBUUUP is the structure of the number.")]
        [NotNull]
        private static ParseResult ParseNumber0FFBBBUUUUP([NotNull] string number, [NotNull] string originalNumber, Province province)
        {
            if (number.Length != 10 && (number.Length != 11 || number[0] != '0'))
                return ParseResult.AsError(originalNumber, province, TaxNumberStatus.InvalidLength);
            const string prefix = "26";
            var startOffset = (number.Length == 10) ? 0 : 1;
            var result = string.Format(
                "{4}{0}0{1}{2}{3}",
                number.Substring(startOffset, 2),
                number.Substring(startOffset + 2, 3),
                number.Substring(startOffset + 5, 4),
                number.Substring(startOffset + 9, 1),
                prefix);
            return ParseResult.AsSuccess(result, province);
        }

        [NotNull]
        private static ParseResult TryParseNumber([NotNull] string number, Province? province)
        {
            if (number == null)
                throw new ArgumentNullException(nameof(number));
            try
            {
                if (province != null && !string.IsNullOrEmpty(number) && ((number.IndexOf(' ') != -1 || number.IndexOf('/') != -1 || number.IndexOf('-') != -1) || number.Length < 13))
                {
                    return ParseNumber(number, province);
                }

                return ParseResult.AsSuccess(number, province);
            }
            catch
            {
                return ParseResult.AsSuccess(number, province);
            }
        }

        /// <summary>
        /// Auseinanderdröseln der Bundesland-spezifischen Finanzamtsnummer
        /// </summary>
        /// <param name="number">Die Nummer des FA (BUFA-Nummer)</param>
        /// <param name="province">Das Bundesland zu dem die Nummer gehört</param>
        /// <returns>Die ermittelte ELSTER-Nummer</returns>
        [NotNull]
        private static ParseResult ParseNumber([NotNull] string number, Province? province)
        {
            if (number == null)
                throw new ArgumentNullException(nameof(number));
            ParseResult result;
            var testNumber = number.Replace(" ", string.Empty).Replace("/", string.Empty).Replace("-", string.Empty);
            switch (province)
            {
                case Elster.Province.Bayern:
                case Elster.Province.Brandenburg:
                case Elster.Province.MecklenburgVorpommern:
                case Elster.Province.Saarland:
                case Elster.Province.Sachsen:
                case Elster.Province.SachsenAnhalt:
                case Elster.Province.Thueringen:
                    // FFFBBBUUUUP
                    result = ParseNumberFFFBBBUUUUP(testNumber, number, province.Value);
                    break;
                case Elster.Province.Berlin:
                case Elster.Province.Hamburg:
                case Elster.Province.RheinlandPfalz:
                case Elster.Province.BadenWuerttemberg:
                case Elster.Province.Bremen:
                case Elster.Province.Niedersachsen:
                case Elster.Province.SchleswigHolstein:
                    // FFBBBUUUUP
                    result = ParseNumberFFBBBUUUUP(testNumber, number, province.Value);
                    break;
                case Elster.Province.Hessen:
                    // 0FFBBBUUUUP
                    result = ParseNumber0FFBBBUUUUP(testNumber, number, province.Value);
                    break;
                case Elster.Province.NordrheinWestfalen:
                    // FFFBBBBUUUP
                    result = ParseNumberFFFBBBBUUUP(testNumber, number, province.Value);
                    break;
                default:
                    result = ParseResult.AsSuccess(number, province);
                    break;
            }

            return result;
        }

        [NotNull]
        private IReadOnlyList<int> GetProvinceCheckDigitFactors()
        {
            IReadOnlyList<int> result;
            switch (Province)
            {
                case Elster.Province.Bayern:
                case Elster.Province.Brandenburg:
                case Elster.Province.MecklenburgVorpommern:
                case Elster.Province.Saarland:
                case Elster.Province.Sachsen:
                case Elster.Province.SachsenAnhalt:
                case Elster.Province.Thueringen:
                    result = _checkDigitFactorsVariant1;
                    break;
                case Elster.Province.Berlin:
                    result = TaxOffices.IsBerlinA(FederalTaxOfficeId, RegionId) ? _checkDigitFactorsBerlinA : _checkDigitFactorsBerlinB;

                    break;
                case Elster.Province.RheinlandPfalz:
                    result = _checkDigitFactorsVariant3;
                    break;
                case Elster.Province.Bremen:
                case Elster.Province.Hamburg:
                    result = _checkDigitFactorsVariant2;
                    break;
                case Elster.Province.Niedersachsen:
                    result = _checkDigitFactorsVariant4;
                    break;
                case Elster.Province.NordrheinWestfalen:
                    result = _checkDigitFactorsVariant5;
                    break;
                case Elster.Province.BadenWuerttemberg:
                case Elster.Province.Hessen:
                case Elster.Province.SchleswigHolstein:
                    result = _checkDigitFactorsVariant6;
                    break;
                default:
                    throw new NotSupportedException($"Das Bundesland {Province} wird nicht unterstützt.");
            }

            Debug.Assert(result == null || result.Count == 12, "Das Ergebnis muss entweder NULL sein oder 12 Elemente haben.");
            return result;
        }

        [NotNull]
        private IReadOnlyList<int> GetProvinceCheckDigitSummand()
        {
            IReadOnlyList<int> result;
            switch (Province)
            {
                case Elster.Province.BadenWuerttemberg:
                case Elster.Province.Hessen:
                case Elster.Province.SchleswigHolstein:
                    result = _checkDigitSummandVariant1;
                    break;
                default:
                    result = _checkDigitSummandVariant2;
                    break;
            }

            Debug.Assert(result == null || result.Count == 12, "Das Ergebnis muss entweder NULL sein oder 12 Elemente haben.");
            return result;
        }

        private TaxNumberStatus DetermineStatus()
        {
            if (Number.Length != 13)
                return TaxNumberStatus.InvalidLength;
            if (Number.Cast<char>().Any(ch => ValidCharacters.IndexOf(ch) == -1))
                return TaxNumberStatus.InvalidCharacter;
            if (Number[4] != '0')
                return TaxNumberStatus.InvalidStructure;
            if (Province == null)
                return TaxNumberStatus.InvalidTaxOffice;
            if (RegionId == 0)
                return TaxNumberStatus.InvalidRegion;
            if (RegionId == 998 || RegionId == 999)
                return TaxNumberStatus.InvalidRegion;

            if (!IsRegionAllowedToBeBelow100 && RegionId < 100)
                return TaxNumberStatus.InvalidRegionId;
            switch (Province)
            {
                case Elster.Province.Bayern:
                    if (RegionId == 999 && DeterminationId == 9999 && CheckDigit == 9)
                        return TaxNumberStatus.InvalidStructure;
                    break;
                case Elster.Province.NordrheinWestfalen:
                    if (((DeterminationId * 10) + CheckDigit) < 9)
                        return TaxNumberStatus.InvalidStructure;
                    break;
            }

            var calculatedCheckDigit = CalculateCheckDigitMethod(GetProvinceCheckDigitSummand(), GetProvinceCheckDigitFactors());
            Debug.Assert(calculatedCheckDigit >= 0, "Die Prüfsumme muss >= 0 sein.");
            if (calculatedCheckDigit >= 10)
                return TaxNumberStatus.InvalidStructure;
            if (calculatedCheckDigit != CheckDigit)
                return TaxNumberStatus.CheckDigitMismatch;
            var info = GetTaxOfficeInfo(FederalTaxOfficeId, AllowTestTaxOffices);
            if (info == null)
                return TaxNumberStatus.InvalidTaxOffice;
            return TaxNumberStatus.Ok;
        }

        /// <summary>
        /// Berechnung der Prüfziffer im modifizerten 11er-Verfahren
        /// </summary>
        /// <param name="summand">Wird ignoriert</param>
        /// <param name="factors">Die Faktoren für die Berechnung der Prüfziffer</param>
        /// <returns>Die berechnete Prüfziffer</returns>
        private int CalculateCheckDigitModified11([NotNull] IReadOnlyList<int> summand, [NotNull] IReadOnlyList<int> factors)
        {
            Debug.Assert(factors != null && factors.Count == 12 && Number.Length == 13, "Die Faktoren müssen vorhanden sein und eine Länge von 12 haben.");
            Debug.Assert(Number.Length == 13, "Die ELSTER-Nummer muss erfolgreich ermittelt worden sein.");

            int sum = 0;
            for (int i = 0; i != 12; ++i)
            {
                var value = Convert.ToInt32(Number.Substring(i, 1), 10);
                value *= factors[i];
                if (value > 9)
                {
                    // Ist das richtig so? Oder muss es (value % 10) + (value / 10) sein?
                    value = (value % 10) + 1;
                }

                sum += value;
            }

            return (10 - (sum % 10)) % 10;
        }

        /// <summary>
        /// Berechnung der Prüfziffer im 11er-Verfahren
        /// </summary>
        /// <param name="summand">Wird ignoriert</param>
        /// <param name="factors">Die Faktoren für die Berechnung der Prüfziffer</param>
        /// <returns>Die berechnete Prüfziffer</returns>
        private int CalculateCheckDigit11([NotNull] IReadOnlyList<int> summand, [NotNull] IReadOnlyList<int> factors)
        {
            Debug.Assert(factors != null && factors.Count == 12 && Number.Length == 13, "Die Faktoren müssen vorhanden sein und eine Länge von 12 haben.");
            Debug.Assert(Number.Length == 13, "Die ELSTER-Nummer muss erfolgreich ermittelt worden sein.");

            var sum = 0;
            for (var i = 0; i != 12; ++i)
            {
                var value = Convert.ToInt32(Number.Substring(i, 1), 10);
                value *= factors[i];
                sum += value;
            }

            var result = sum % 11;
            if (result != 0)
                result = 11 - result;
            return result;
        }

        /// <summary>
        /// Berechnung der Prüfziffer im 11er-Verfahren für NRW
        /// </summary>
        /// <param name="summand">Wird ignoriert</param>
        /// <param name="factors">Die Faktoren für die Berechnung der Prüfziffer</param>
        /// <returns>Die berechnete Prüfziffer</returns>
        private int CalculateCheckDigitNrw11([NotNull] IReadOnlyList<int> summand, [NotNull] IReadOnlyList<int> factors)
        {
            var result = CalculateCheckDigit11(summand, factors);
            if (result != 0)
                result = 11 - result;
            return result;
        }

        /// <summary>
        /// Berechnung der Prüfziffer im 2er-Verfahren
        /// </summary>
        /// <param name="summand">Summand der vor den Faktoren angewandt wird.</param>
        /// <param name="factors">Die Faktoren für die Berechnung der Prüfziffer</param>
        /// <returns>Die berechnete Prüfziffer</returns>
        private int CalculateCheckDigit2([NotNull] IReadOnlyList<int> summand, [NotNull] IReadOnlyList<int> factors)
        {
            Debug.Assert(summand != null && summand.Count == 12, "Summand muss vorhanden sein und eine Länge von 12 haben.");
            Debug.Assert(factors != null && factors.Count == 12 && Number.Length == 13, "Die Faktoren müssen vorhanden sein und eine Länge von 12 haben.");
            Debug.Assert(Number.Length == 13, "Die ELSTER-Nummer muss erfolgreich ermittelt worden sein.");

            var sum = 0;
            for (var i = 0; i != 12; ++i)
            {
                var value = Convert.ToInt32(Number.Substring(i, 1), 10);
                value = ((value + summand[i]) % 10) * factors[i];
                while (value > 9)
                    value = CalculateSumOfDigits(value);
                sum += value;
            }

            return (10 - (sum % 10)) % 10;
        }

        /// <summary>
        /// Quersumme errechnen
        /// </summary>
        /// <param name="value">Der Wert für den die Quersumme zu berechnen ist</param>
        /// <returns>Die Quersumme des übergebenen Wertes</returns>
        private int CalculateSumOfDigits(int value)
        {
            var result = 0;
            while (value != 0)
            {
                result += value % 10;
                value /= 10;
            }

            return result;
        }

        private Province? GetProvinceForTaxOfficeId()
        {
            var info = GetTaxOfficeInfo(FederalTaxOfficeId, true);
            return info?.Province;
        }

        [NotNull]
        private string GetNumberPart(int offset, int length, [NotNull] string defaultValue)
        {
            if (Number.Length >= (offset + length))
                return Number.Substring(offset, length);
            return defaultValue;
        }

        private class ParseResult
        {
            private ParseResult([NotNull] string taxNumber, Province? province, TaxNumberStatus status)
            {
                TaxNumber = taxNumber;
                Status = status;
                Province = province;
            }

            private ParseResult([NotNull] string taxNumber, Province? province)
            {
                TaxNumber = taxNumber;
                Province = province;
            }

            public string TaxNumber { get; }

            public Province? Province { get; }

            public TaxNumberStatus? Status { get; }

            public static ParseResult AsError([NotNull] string taxNumber, Province? province, TaxNumberStatus status)
            {
                return new ParseResult(taxNumber, province, status);
            }

            public static ParseResult AsSuccess([NotNull] string taxNumber, Province? province)
            {
                return new ParseResult(taxNumber, province);
            }
        }
    }
}
