﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="lstb_AdresseCType.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Xml.Serialization;

namespace Dataline.Elster.Lohn.LStB201201
{
    public partial class lstb_AdresseCType
    {
        [XmlIgnore]
        public AuslandsPLZCType AuslandsPLZ
        {
            get { return Item as AuslandsPLZCType; }
        }

        [XmlIgnore]
        public string PLZ
        {
            get { return Item as string; }
        }
    }
}
