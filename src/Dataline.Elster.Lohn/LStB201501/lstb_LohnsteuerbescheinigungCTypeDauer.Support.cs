﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_LohnsteuerbescheinigungCTypeDauer.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Globalization;
using System.Xml.Serialization;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Lohn
{
    namespace LStB201501
    {
        public partial class lstb_LohnsteuerbescheinigungCTypeDauer
        {
            [XmlIgnore]
            public DateTime? AnfangDatum
            {
                get
                {
                    DateTime result;
                    if (!DateTime.TryParseExact(Anfang + XmlSchemaUtilities.GetEnumXmlValue(jahr), "ddMMyyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result))
                        return null;
                    return result;
                }
            }

            [XmlIgnore]
            public DateTime? EndeDatum
            {
                get
                {
                    DateTime result;
                    if (!DateTime.TryParseExact(Ende + XmlSchemaUtilities.GetEnumXmlValue(jahr), "ddMMyyyy", CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out result))
                        return null;
                    return result;
                }
            }

            [XmlIgnore]
            public int FuerJahr
            {
                get { return Convert.ToInt32(XmlSchemaUtilities.GetEnumXmlValue(jahr)); }
            }
        }
    }
}
