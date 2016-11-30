// <copyright file="DatenabholungTests.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

using Dataline.Elster.Datenabholung.V6;

using JetBrains.Annotations;

using Xunit;

namespace Dataline.Elster.Test.DatenabholungV6
{
    public class DatenabholungTests : ElsterDocumentValidation
    {
        [Theory(DisplayName = "Datenabholung V6")]
        [InlineData("1_ElsterDatenabholung_Liste_Anfrage.xml")]
        [InlineData("2_ElsterDatenabholung_Liste_Antwort.xml")]
        [InlineData("Einzelabholung/3_Einzelbescheid_ElsterDatenabholung_Abholung_Anfrage.xml")]
        [InlineData("Einzelabholung/4a_Einzelbescheid_ElsterDatenabholung_Abholung_Antwort_Direkt.xml")]
        [InlineData("Einzelabholung/4a_Einzelbescheid_ElsterDatenabholung_Abholung_Antwort_Direkt_mit_Metadaten.xml")]
        [InlineData("Einzelabholung/4b1_Einzelbescheid_ElsterDatenabholung_Abholung_Antwort_WebserverLink.xml")]
        [InlineData("Einzelabholung/4b2_Einzelbescheid_ElsterDatenabholung_Abholung_Antwort_WebserverDatei.xml")]
        [InlineData("Einzelabholung/5_Einzelbescheid_ElsterDatenabholung_Bestaetigung.xml")]
        [InlineData("Einzelabholung/6_Einzelbescheid_ElsterDatenabholung_Bestaetigung_Antwort.xml")]
        [InlineData("Sammelabholung/3_Sammelbescheid_ElsterDatenabholung_Abholung_Anfrage.xml")]
        [InlineData("Sammelabholung/4a_Sammelbescheid_ElsterDatenabholung_Abholung_Antwort_Direkt.xml")]
        [InlineData("Sammelabholung/4b1_Sammelbescheid_ElsterDatenabholung_Abholung_Antwort_WebserverLink.xml")]
        [InlineData("Sammelabholung/4b2_Sammelbescheid_ElsterDatenabholung_Abholung_Antwort_WebServerDatei.xml")]
        [InlineData("Sammelabholung/5_Sammelbescheid_ElsterDatenabholung_Bestaetigung.xml")]
        [InlineData("Sammelabholung/6_Sammelbescheid_ElsterDatenabholung_Bestaetigung_Antwort.xml")]
        public void TestDeserialize(string relativeFileName)
        {
            var provider = new DatenabholungResourceProvider();
            var doc = Load(relativeFileName);
            TestDocument(doc, provider, provider.BaseFileNames.Single());
        }

        private static XDocument Load(string relativeFileName)
        {
            var asm = typeof(DatenabholungTests).Assembly;
            var resFileName = $"Daten.{relativeFileName.Replace('/', '.')}";
            using (var resStream = asm.GetManifestResourceStream(typeof(DatenabholungTests), resFileName))
            {
                Assert.NotNull(resStream);
                return XDocument.Load(resStream);
            }
        }
    }
}
