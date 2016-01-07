using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

using Dataline.Elster.Datenuebermittler2014;

using Xunit;

namespace Dataline.Elster.Test.Datenuebermittler2014
{
    public class DatenuebermittlerTests2014 : ElsterDocumentValidation
    {
        [Fact]
        public void TestRequestResponseValidation()
        {
            var provider = new Datenuebermittler2014ResourceProvider();
            string[] csvLines;
            using (var reader = new System.IO.StreamReader(LoadResource("uebersicht.csv")))
                csvLines = reader.ReadToEnd().Split(new[]
                {
                    '\r', '\n'
                }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var csvLine in csvLines.Skip(3))
            {
                var parts = csvLine.Split(new[]
                {
                    ';'
                }, 4);
                var number = parts[0];
                var requestFileName = $"requests/{number}.request.xml";
                var requestDoc = Load(requestFileName, number);
                TestDocument(requestDoc, provider, provider.BaseFileNames.Single(), true);
                var responseDataFileName = $"aenderungliste/{number}.0.xml";
                var responseDataDoc = Load(responseDataFileName, number);
                TestDocument(responseDataDoc, provider, provider.BaseFileNames.Single(), true);
            }
        }

        private static XDocument Load(string relativeFileName, string ticketNumber)
        {
            using (var resStream = LoadResource(relativeFileName.Replace('/', '.')))
            {
                var doc = XDocument.Load(resStream, LoadOptions.PreserveWhitespace);
                var contents = doc.ToString(SaveOptions.DisableFormatting);
                contents = contents.Replace("@TTicket@", ticketNumber.PadRight(19, '0'));
                doc = XDocument.Parse(contents, LoadOptions.PreserveWhitespace);
                Assert.NotNull(doc.Root);
                var ns = doc.Root.Name.Namespace;
                var ndh = doc.Elements(ns + "Elster").Elements(ns + "DatenTeil").Elements(ns + "Nutzdatenblock").Elements(ns + "NutzdatenHeader");
                foreach (var element in ndh)
                {
                    if (element.Element(ns + "Hersteller") == null)
                    {
                        element.Add(
                            new XElement(
                                ns + "Hersteller",
                                new XElement(ns + "ProduktName", "Datenabholung"),
                                new XElement(ns + "ProduktVersion", "2014")));
                    }
                    if (element.Element(ns + "DatenLieferant") == null)
                    {
                        element.Add(new XElement(ns + "DatenLieferant", "String, der Lieferanteninfo enthält"));
                    }
                }
                return doc;
            }
        }

        private static Stream LoadResource(string resourceName)
        {
            var baseType = typeof(DatenuebermittlerTests2014);
            var asm = baseType.Assembly;
            var resFileName = $"Daten.{resourceName}";
            var resStream = asm.GetManifestResourceStream(baseType, resFileName);
            Assert.NotNull(resStream);
            return resStream;
        }
    }
}
