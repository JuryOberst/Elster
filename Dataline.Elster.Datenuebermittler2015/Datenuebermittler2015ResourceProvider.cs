// <copyright file="Datenuebermittler2015ResourceProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Datenuebermittler2015
{
    /// <summary>
    /// Der XSD-Anbieter für das Modul Datenübermittler
    /// </summary>
    public class Datenuebermittler2015ResourceProvider : IResourceProvider
    {
        private readonly IResourceProvider _basisResourceProvider = new BasisResourceProvider();

        private readonly Dictionary<string, string> _fileToResourceName;

        private readonly Assembly _assembly;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="Datenuebermittler2015ResourceProvider"/> Klasse.
        /// </summary>
        public Datenuebermittler2015ResourceProvider()
        {
            var type = GetType();
            var basePath = $"{type.Namespace}.xsd.";
            _assembly = type.GetTypeInfo().Assembly;
            _fileToResourceName = _assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(basePath))
                .ToDictionary(x => ReplacePath(x.Substring(basePath.Length)));
            var fileNames = _fileToResourceName.Keys.ToList();
            fileNames.AddRange(_basisResourceProvider.FileNames);
            FileNames = fileNames;
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> FileNames { get; }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> BaseFileNames { get; } = new[]
        {
            "elster0810_elo2_extern-2015.xsd"
        };

        /// <inheritdoc/>
        public Stream CreateStream(string fileName)
        {
            string resourceName;
            if (!_fileToResourceName.TryGetValue(fileName, out resourceName))
            {
                if (fileName.StartsWith("../"))
                    fileName = fileName.Substring(3);
            if (!_fileToResourceName.TryGetValue($"datenuebermittler-2015/{fileName}", out resourceName))
                    return _basisResourceProvider.CreateStream(fileName);
            }
            return _assembly.GetManifestResourceStream(resourceName);
        }

        private static string ReplacePath(string fileName)
        {
            const string path = "datenuebermittler_2015";
            if (fileName.StartsWith(path + "."))
                return $"datenuebermittler-2015/{fileName.Substring(path.Length + 1)}";
            return fileName;
        }
    }
}
