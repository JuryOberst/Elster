// <copyright file="INutzdatenElement.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Xml.Serialization;

namespace Dataline.Elster.Lohn
{
    /// <summary>
    /// Ein Element, das im Nutzdatenblock vorkommen darf
    /// </summary>
    public interface INutzdatenElement
    {
        /// <summary>
        /// Holt die Art des Nutzdatenelements
        /// </summary>
        [XmlIgnore]
        string ElementArt { get; }

        /// <summary>
        /// Holt die Version des Nutzdatenelements
        /// </summary>
        [XmlIgnore]
        string ElementVersion { get; }
    }
}
