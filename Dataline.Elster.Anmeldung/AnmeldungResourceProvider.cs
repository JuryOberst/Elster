// <copyright file="DatenabholungResourceProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Dataline.Elster.Basis;

namespace Dataline.Elster.Anmeldung
{
    /// <summary>
    /// Der XSD-Anbieter für das Modul Anmeldung
    /// </summary>
    public class AnmeldungResourceProvider : IResourceProvider
    {
        private readonly IResourceProvider _basisResourceProvider = new BasisResourceProvider();

        private readonly Dictionary<string, string> _fileToResourceName;

        private readonly Assembly _assembly;

        /// <summary>
        /// Initialisiert eine neue Instanz der <see cref="AnmeldungResourceProvider"/> Klasse.
        /// </summary>
        public AnmeldungResourceProvider()
        {
            var type = GetType();
            var basePath = $"{type.Namespace}.xsd.";
            _assembly = type.GetTypeInfo().Assembly;
            _fileToResourceName = _assembly.GetManifestResourceNames()
                .Where(x => x.StartsWith(basePath))
                .ToDictionary(x => x.Substring(basePath.Length));
            var fileNames = _fileToResourceName.Keys.ToList();
            BaseFileNames = fileNames.Where(x => x.EndsWith("_extern.xsd")).ToList();
            fileNames.AddRange(_basisResourceProvider.FileNames);
            FileNames = fileNames;
        }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> FileNames { get; }

        /// <inheritdoc/>
        public IReadOnlyCollection<string> BaseFileNames { get; }

        /// <inheritdoc/>
        public Stream CreateStream(string fileName)
        {
            string resourceName;
            if (!_fileToResourceName.TryGetValue(fileName, out resourceName))
                return _basisResourceProvider.CreateStream(fileName);
            return _assembly.GetManifestResourceStream(resourceName);
        }

        public string GetBaseFileNameAnmeldungssteuer(int year, int month = 1)
        {
            if (year < 2004 || year > 2016)
                throw new ArgumentOutOfRangeException(nameof(year));
            if (month != 1)
                throw new ArgumentOutOfRangeException(nameof(month));
            var fileName = $"elster0810_LStA_{year:D4}{month:D2}_extern.xsd";
            return fileName;
        }

        public string GetBaseFileNameUmsatzsteuer(int year, int month)
        {
            if (year < 2004 || year > 2016)
                throw new ArgumentOutOfRangeException(nameof(year));
            if (month != 1)
            {
                if (month != 2)
                    throw new ArgumentOutOfRangeException(nameof(month));
                if (year != 2011)
                    throw new ArgumentOutOfRangeException(nameof(month));
            }
            var fileName = $"elster0810_UStA_{year:D4}{month:D2}_extern.xsd";
            return fileName;
        }
    }
}
