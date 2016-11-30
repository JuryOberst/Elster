// <copyright file="ProtokollAnforderungCType.Support.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using Dataline.Elster.Basis;

namespace Dataline.Elster.Lohn.Protocol3
{
    public partial class ProtokollAnforderungCType : INutzdatenElement
    {
        /// <inheritdoc/>
        string INutzdatenElement.ElementArt => "Protocol";

        /// <inheritdoc/>
        string INutzdatenElement.ElementVersion => XmlSchemaUtilities.GetEnumXmlValue(version);
    }
}
