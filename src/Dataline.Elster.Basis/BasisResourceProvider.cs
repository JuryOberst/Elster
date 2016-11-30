// <copyright file="BasisResourceProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Dataline.Elster.Basis
{
    /// <summary>
    /// Der XSD-Anbieter für das Basis-Modul
    /// </summary>
    public class BasisResourceProvider : IResourceProvider
    {
        private readonly Dictionary<string, string> _fileToResourceName;

        private readonly Assembly _assembly;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="BasisResourceProvider"/> Klasse.
        /// </summary>
        public BasisResourceProvider()
        {
            var type = GetType();
            var basePath = $"{type.Namespace}.xsd.";
            _assembly = type.GetTypeInfo().Assembly;
            _fileToResourceName = _assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(basePath))
                .ToDictionary(x => x.Substring(basePath.Length));
            FileNames = _fileToResourceName.Keys.ToList();
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> FileNames { get; }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> BaseFileNames { get; } = new[]
        {
            "th000008_extern.xsd", "ndh000010_extern.xsd"
        };

        /// <inheritdoc/>
        public Stream CreateStream(string fileName)
        {
            string resourceName;
            if (!_fileToResourceName.TryGetValue(fileName, out resourceName))
                return null;
            return _assembly.GetManifestResourceStream(resourceName);
        }
    }
}
