﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster.Lohn
{
    namespace LStB201601
    {
        public partial class lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse
        {
            public override bool Equals(object obj)
            {
                var other = obj as lstb_BesteuerungsmerkmaleCTypeELStAMSteuerklasse;
                if (other == null)
                    return false;

                return this.faktor == other.faktor && this.faktorSpecified == other.faktorSpecified && this.Value == other.Value;
            }

            public override int GetHashCode()
            {
                return faktor.GetHashCode() ^ faktorSpecified.GetHashCode() ^ Value.GetHashCode();
            }
        }
    }
}
