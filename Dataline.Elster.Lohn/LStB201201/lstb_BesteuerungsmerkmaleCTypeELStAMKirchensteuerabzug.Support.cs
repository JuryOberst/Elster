﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster.Lohn
{
    namespace LStB201201
    {
        public partial class lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug
        {
            public override bool Equals(object obj)
            {
                var other = obj as lstb_BesteuerungsmerkmaleCTypeELStAMKirchensteuerabzug;
                if (other == null)
                    return false;

                return this.konfession == other.konfession && this.ehegkonfession == other.ehegkonfession && this.ehegkonfessionSpecified == other.ehegkonfessionSpecified;
            }

            public override int GetHashCode()
            {
                return konfession.GetHashCode() ^ ehegkonfession.GetHashCode() ^ ehegkonfessionSpecified.GetHashCode();
            }
        }
    }
}
