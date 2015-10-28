// <copyright file="LohnResourceProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Lohn
{
    /// <summary>
    /// Der XSD-Anbieter für das Modul Elster Lohn
    /// </summary>
    public class LohnResourceProvider : IResourceProvider
    {
        private readonly IResourceProvider _basisResourceProvider = new BasisResourceProvider();

        private readonly Dictionary<string, string> _fileToResourceName;

        private readonly Assembly _assembly;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="LohnResourceProvider"/> Klasse.
        /// </summary>
        public LohnResourceProvider()
        {
            var type = GetType();
            var basePath = $"{type.Namespace}.xsd.";
            _assembly = type.GetTypeInfo().Assembly;
            _fileToResourceName = _assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(basePath))
                .ToDictionary(x => x.Substring(basePath.Length));
            var fileNames = _fileToResourceName.Keys.ToList();
            fileNames.AddRange(_basisResourceProvider.FileNames);
            FileNames = fileNames;
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> FileNames
        { get; }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> BaseFileNames { get; } = new[]
        {
            "elster0810_elo_extern.xsd"
        };

        /// <inheritdoc/>
        public Stream CreateStream(string fileName)
        {
            string resourceName;
            if (!_fileToResourceName.TryGetValue(fileName, out resourceName))
                return _basisResourceProvider.CreateStream(fileName);
            return _assembly.GetManifestResourceStream(resourceName);
        }
    }
}
