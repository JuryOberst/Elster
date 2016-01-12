// <copyright file="ProtokollCType.Support.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

namespace Dataline.Elster.Lohn.Protocol5
{
    public partial class ProtokollCType : INutzdatenElement
    {
        /// <inheritdoc/>
        string INutzdatenElement.ElementArt => "Protocol";

        /// <inheritdoc/>
        string INutzdatenElement.ElementVersion => "5";
    }
}
