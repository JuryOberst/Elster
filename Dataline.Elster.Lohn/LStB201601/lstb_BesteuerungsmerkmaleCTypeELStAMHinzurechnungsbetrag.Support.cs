﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster.Lohn
{
    namespace LStB201601
    {
        public partial class lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag
        {
            public override bool Equals(object obj)
            {
                var other = obj as lstb_BesteuerungsmerkmaleCTypeELStAMHinzurechnungsbetrag;
                if (other == null)
                    return false;

                return jahr == other.jahr && monat == other.monat && tag == other.tag && tagSpecified == other.tagSpecified && woche == other.woche && wocheSpecified == other.wocheSpecified;
            }

            public override int GetHashCode()
            {
                return jahr.GetHashCode() ^ monat.GetHashCode() ^ tag.GetHashCode() ^ tagSpecified.GetHashCode() ^ woche.GetHashCode() ^ wocheSpecified.GetHashCode();
            }
        }
    }
}
