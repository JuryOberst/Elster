// <copyright file="IResourceProvider.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.IO;

namespace Dataline.Elster.Basis
{
    /// <summary>
    /// Über diese Schittstelle können die XSD-Dateien dieses Moduls abgefragt werden
    /// </summary>
    public interface IResourceProvider
    {
        /// <summary>
        /// Holt eine Liste von Dateinamen, die über dieses Modul abgefragt werden können
        /// </summary>
        IReadOnlyCollection<string> FileNames { get; }

        /// <summary>
        /// Holt eine Liste von Dateinamen, die als Startpunkt für Validierungen dienen können
        /// </summary>
        IReadOnlyCollection<string> BaseFileNames { get; }

            /// <summary>
        /// Erstellt einen <see cref="Stream"/> für eine von diesem Modul zur Verfügung gestellten Datei
        /// </summary>
        /// <param name="fileName">Der Name der Datei dessen Stream erstellt werden soll</param>
        /// <returns>Der Stream der anhand des <paramref name="fileName"/> erstellt wurde</returns>
        Stream CreateStream(string fileName);
    }
}
