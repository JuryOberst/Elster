﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_BesteuerungsgrundlagenCTypeVBez.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Xml.Serialization;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Lohn
{
    namespace LStB201501
    {
        public partial class lstb_BesteuerungsgrundlagenCTypeVBez
        {
            [XmlIgnore]
            public DateTime BeginnDatum
            {
                get
                {
                    var monat = (beginnSpecified ? XmlSchemaUtilities.GetEnumXmlValue(beginn) : "01");
                    return new DateTime(Convert.ToInt32(jahr, 10), Convert.ToInt32(monat, 10), 1);
                }
            }

            [XmlIgnore]
            public DateTime EndeDatum
            {
                get
                {
                    var monat = (endeSpecified ? XmlSchemaUtilities.GetEnumXmlValue(ende) : "12");
                    return (new DateTime(Convert.ToInt32(jahr, 10), Convert.ToInt32(monat, 10), 1)).AddMonths(1).AddDays(-1);
                }
            }
        }
    }
}
