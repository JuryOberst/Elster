// <copyright file="TaxOfficeChange.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Dataline.Elster
{
    /// <summary>
    /// Repräsentiert die Änderung an einem Finanzamt
    /// </summary>
    internal sealed class TaxOfficeChange
    {
        private TaxOfficeChange(TaxOfficeChangeType changeType)
        {
            ChangeType = changeType;
        }

        /// <summary>
        /// Holt die Art der Änderung
        /// </summary>
        public TaxOfficeChangeType ChangeType { get; }

        /// <summary>
        /// Holt die Bundesfinanzamtsnummer
        /// </summary>
        public int BufaNr { get; private set; }

        /// <summary>
        /// Holt die neuen Bundesfinanzamtsnummern
        /// </summary>
        public IReadOnlyList<int> NewBufaNr { get; private set; }

        /// <summary>
        /// Holt den Namen des Finanzamts
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Holt das Bundesland des Finanzamts
        /// </summary>
        public Province Province { get; private set; }

        /// <summary>
        /// Holt einen Wert, der angibt, ob das Finanzamt ein Test-Finanzamt ist
        /// </summary>
        public bool IsTest { get; private set; }

        /// <summary>
        /// Holt einen Wert, der angibt, ob das Finanzamt aktiv ist
        /// </summary>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Holt einen Wert, der angibt, ob das Finanzamt Lohnsteueranmeldungen akzeptiert
        /// </summary>
        public bool? SupportsElsterAnmeldung { get; private set; }

        /// <summary>
        /// Ermittelt das Finanzamt anhand der Bundesfinanzamtsnummer
        /// </summary>
        /// <param name="bufaNr">Die Bundesfinanzamtsnummer anhand derer das Bundesland ermittelt wird</param>
        /// <returns>Das Bundesland das anhand der Bundesfinanzamtsnummer ermittelt wurde</returns>
        public static Province? GetProvince(int bufaNr)
        {
            var land = bufaNr / 100;
            Province? province;
            switch (land)
            {
                case 10:
                    province = Province.Saarland;
                    break;
                case 11:
                    province = Province.Berlin;
                    break;
                case 21:
                    province = Province.SchleswigHolstein;
                    break;
                case 22:
                    province = Province.Hamburg;
                    break;
                case 23:
                    province = Province.Niedersachsen;
                    break;
                case 24:
                    province = Province.Bremen;
                    break;
                case 26:
                    province = Province.Hessen;
                    break;
                case 27:
                    province = Province.RheinlandPfalz;
                    break;
                case 28:
                    province = Province.BadenWuerttemberg;
                    break;
                case 30:
                    province = Province.Brandenburg;
                    break;
                case 31:
                    province = Province.SachsenAnhalt;
                    break;
                case 32:
                    province = Province.Sachsen;
                    break;
                case 40:
                    province = Province.MecklenburgVorpommern;
                    break;
                case 41:
                    province = Province.Thueringen;
                    break;
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                    province = Province.NordrheinWestfalen;
                    break;
                case 91:
                case 92:
                    province = Province.Bayern;
                    break;
                default:
                    province = null;
                    break;
            }

            return province;
        }

        /// <summary>
        /// Erstellt ein <see cref="TaxOfficeChange"/> für ein neues Finanzamt
        /// </summary>
        /// <param name="bufaNr">Die Bundesfinanzamtsnummer</param>
        /// <param name="name">Der Name des Finanzamts</param>
        /// <param name="supportsElsterAnmeldung">Werden Lohnsteueranmeldungen akzeptiert?</param>
        /// <param name="isTest">Ist dieses Finanzamt ein Test-Finanzamt?</param>
        /// <returns>Das neue <see cref="TaxOfficeChange"/></returns>
        public static TaxOfficeChange New(int bufaNr, string name, bool supportsElsterAnmeldung, bool isTest = false)
        {
            var province = GetProvince(bufaNr);
            if (province == null)
                throw new ArgumentOutOfRangeException(nameof(bufaNr), "Die Bundesfinanzamtsnummer konnte keinem Bundesland zugeordnet werden.");
            return new TaxOfficeChange(TaxOfficeChangeType.New)
            {
                BufaNr = bufaNr,
                Name = name,
                IsValid = true,
                SupportsElsterAnmeldung = supportsElsterAnmeldung,
                IsTest = isTest,
                Province = province.Value,
            };
        }

        /// <summary>
        /// Erstellt ein <see cref="TaxOfficeChange"/> für ein Finanzamt, das entweder deaktiviert oder reaktiviert wird
        /// </summary>
        /// <param name="bufaNr">Die Bundesfinanzamtsnummer</param>
        /// <param name="isValid"><code>true</code> wenn das Finanzamt reaktiviert wird</param>
        /// <returns>Das neue <see cref="TaxOfficeChange"/></returns>
        public static TaxOfficeChange SetValid(int bufaNr, bool isValid)
        {
            return new TaxOfficeChange(TaxOfficeChangeType.ChangeValid)
            {
                BufaNr = bufaNr,
                IsValid = isValid,
            };
        }

        /// <summary>
        /// Umleitung auf ein neues Finanzamt, wenn ein anderes Geschlossen wird
        /// </summary>
        /// <param name="bufaNr">Die Bundesfinanzamtsnummer</param>
        /// <param name="isValid"><code>false</code> wenn das Finanzamt deaktiviert wird</param>
        /// <param name="newBufaNr">Die Bundesfinanzamtsnummer auf die umgeleitet werden soll</param>
        /// <param name="newBufaNrOther">Die anderen Bundesfinanzamtsnummern auf die umgeleitet werden soll</param>
        /// <returns>Das neue <see cref="TaxOfficeChange"/></returns>
        public static TaxOfficeChange Redirect(int bufaNr, bool isValid, int newBufaNr, params int[] newBufaNrOther)
        {
            return new TaxOfficeChange(TaxOfficeChangeType.RedirectTo)
                {
                    BufaNr = bufaNr,
                    NewBufaNr = new[] { newBufaNr }.Union(newBufaNrOther).ToArray(),
                    IsValid = isValid,
                    SupportsElsterAnmeldung = isValid ? (bool?)false : null,
                };
        }

        /// <summary>
        /// Änderungen an einem Finanzamt
        /// </summary>
        /// <param name="bufaNr">Die Bundesfinanzamtsnummer</param>
        /// <param name="newName">Der neue Finanzamtsname</param>
        /// <param name="newSupportsElsterAnmeldung">Werden Lohnsteueranmeldungen akzeptiert?</param>
        /// <returns>Das neue <see cref="TaxOfficeChange"/></returns>
        public static TaxOfficeChange Change(int bufaNr, string newName, bool? newSupportsElsterAnmeldung = null)
        {
            return new TaxOfficeChange(TaxOfficeChangeType.ChangeName)
            {
                BufaNr = bufaNr,
                Name = newName,
                SupportsElsterAnmeldung = newSupportsElsterAnmeldung,
            };
        }
    }
}
