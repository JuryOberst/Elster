// <copyright file="ResourceProviderXmlResolver.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Xml;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Test
{
    public class ResourceProviderXmlResolver : XmlResolver
    {
        public static readonly Uri TestRootUri = new Uri("http://localhost/");
        private readonly IResourceProvider _provider;
        private readonly Uri _schemaRootUri;

        public ResourceProviderXmlResolver(Uri schemaRootUri, IResourceProvider provider)
        {
            _schemaRootUri = schemaRootUri;
            _provider = provider;
        }

        public bool EntityFetched { get; private set; }

        public override ICredentials Credentials
        {
            set
            {
                // Wird nicht benötigt, da wir die Schemata als Ressource eingebettet haben.
            }
        }

        public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
        {
            Uri relativeUri;
            if (absoluteUri.IsFile)
            {
                var tempFileName = Path.GetFileName(absoluteUri.LocalPath);
                relativeUri = new Uri($"{tempFileName}", UriKind.Relative);
            }
            else
            {
                relativeUri = _schemaRootUri.MakeRelativeUri(absoluteUri);
            }
            var fileName = relativeUri.OriginalString;
            Debug.WriteLine("{0} -> {1}", absoluteUri, fileName);
            var stream = _provider.CreateStream(fileName);
            if (stream == null)
                throw new System.Xml.Schema.XmlSchemaException($"Schema from resource {absoluteUri} not found. Determined file name was {fileName}.");
            EntityFetched = true;
            return stream;
        }
    }
}
