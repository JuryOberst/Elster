﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_BesteuerungsgrundlagenCType.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Linq;
using System.Xml.Serialization;

namespace Dataline.Elster.Lohn
{
    namespace LStB201302
    {
        public partial class lstb_BesteuerungsgrundlagenCType
        {
            /// <remarks/>
            [XmlIgnore]
            public bool LSteuerMKalJahrSpecified { get; set; }

            /// <remarks/>
            [XmlIgnore]
            public bool SoliMKalJahrSpecified { get; set; }

            [XmlIgnore]
            public decimal VBezGesamt
            {
                get
                {
                    if (VBez == null || VBez.Count == 0)
                        return 0m;
                    return VBez.Sum(x => x.Value);
                }
            }

            [XmlIgnore]
            public decimal VBezBemGrFreibetragGesamt
            {
                get
                {
                    if (VBez == null || VBez.Count == 0)
                        return 0m;
                    return VBez.Sum(x => x.bmgfreibetrag);
                }
            }

            [XmlIgnore]
            public decimal VBezEinmVersBezugGesamt
            {
                get
                {
                    if (VBez == null || VBez.Count == 0)
                        return 0m;
                    return VBez.Where(x => x.einmversbezugSpecified).Sum(x => x.einmversbezug);
                }
            }

            /// <summary>
            /// Gesamt-Wert von: Ermäßigt besteuerte Versorgungsbezüge für mehrere Kalenderjahre
            /// </summary>
            [XmlIgnore]
            public decimal ErmStVBezMKalJahrGesamt
            {
                get
                {
                    if (ErmStVBezMKalJahr == null || ErmStVBezMKalJahr.Count == 0)
                        return 0m;
                    return ErmStVBezMKalJahr.Sum(x => x.Value);
                }
            }

            /// <summary>
            /// Gesamt-Wert von: Versorgungsbezüge für mehrere Kalenderjahre, die nicht ermäßigt besteuert wurden
            /// </summary>
            [XmlIgnore]
            public decimal NErmStVBezMKalJahrGesamt
            {
                get
                {
                    if (NErmStVBezMKalJahr == null || ErmStVBezMKalJahr.Count == 0)
                        return 0m;
                    return NErmStVBezMKalJahr.Sum(x => x.Value);
                }
            }
        }
    }
}
