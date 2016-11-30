// <copyright file="Datenuebermittler2015ResourceProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Datenuebermittler2014
{
    /// <summary>
    /// Der XSD-Anbieter für das Modul Datenübermittler
    /// </summary>
    public class Datenuebermittler2014ResourceProvider : IResourceProvider
    {
        private readonly Dictionary<string, string> _fileToResourceName;

        private readonly Assembly _assembly;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Datenuebermittler2014ResourceProvider"/> Klasse.
        /// </summary>
        public Datenuebermittler2014ResourceProvider()
        {
            var type = GetType();
            var basePath = $"{type.Namespace}.xsd.";
            _assembly = type.GetTypeInfo().Assembly;
            _fileToResourceName = _assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(basePath))
                .ToDictionary(x => ReplacePath(x.Substring(basePath.Length)));
            var fileNames = _fileToResourceName.Keys.ToList();
            FileNames = fileNames;
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> FileNames { get; }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> BaseFileNames { get; } = new[]
        {
            "datenuebermittler/elster0810_elo2_extern.xsd"
        };

        /// <inheritdoc/>
        public Stream CreateStream(string fileName)
        {
            var resourceName = _fileToResourceName[fileName];
            return _assembly.GetManifestResourceStream(resourceName);
        }

        private static string ReplacePath(string fileName)
        {
            const string pathElo2 = "datenuebermittler";
            if (fileName.StartsWith(pathElo2 + "."))
                return $"{pathElo2}/{fileName.Substring(pathElo2.Length + 1)}";
            const string pathBasis = "basis";
            if (fileName.StartsWith(pathBasis + "."))
                return $"{pathBasis}/{fileName.Substring(pathBasis.Length + 1)}";
            return fileName;
        }
    }
}
