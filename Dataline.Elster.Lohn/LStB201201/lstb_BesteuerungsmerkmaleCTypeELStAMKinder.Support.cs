﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_BesteuerungsmerkmaleCTypeELStAMKinder.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster.Lohn
{
    namespace LStB201201
    {
        public partial class lstb_BesteuerungsmerkmaleCTypeELStAMKinder
        {
            public override bool Equals(object obj)
            {
                var other = obj as lstb_BesteuerungsmerkmaleCTypeELStAMKinder;
                if (other == null)
                    return false;

                return this.Value == other.Value;
            }

            public override int GetHashCode()
            {
                return Value.GetHashCode();
            }
        }
    }
}
