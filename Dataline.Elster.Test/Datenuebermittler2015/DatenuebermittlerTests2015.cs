using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

using Dataline.Elster.Datenuebermittler2015;

using Xunit;

namespace Dataline.Elster.Test.Datenuebermittler2015
{
    public class DatenuebermittlerTests2015 : ElsterDocumentValidation
    {
        [Theory(DisplayName = "Datenübermittler 2015")]
        [InlineData("abmelden/abmelde_request.xml")]
        [InlineData("abmelden/abmelde_response.xml")]
        [InlineData("anmelden/anmelde_request.xml")]
        [InlineData("anmelden/anmelde_response.xml")]
        [InlineData("anmelden/bruttoliste2015_response.xml")]
        [InlineData("anmelden/monatsliste2015_response.xml")]
        [InlineData("exception/exception_request.xml")]
        [InlineData("exception/exception_response.xml")]
        //[InlineData("exception/exception2_request.xml")]
        [InlineData("exception/exception2_response.xml")]
        [InlineData("ummelden/ummelde_request.xml")]
        [InlineData("ummelden/ummelde_response.xml")]
        public void TestRequestResponseValidation(string testFileName)
        {
            var provider = new Datenuebermittler2015ResourceProvider();
            var doc = Load(testFileName);
            TestDocument(doc, provider, provider.BaseFileNames.Single());
        }

        private static XDocument Load(string relativeFileName)
        {
            using (var resStream = LoadResource(relativeFileName.Replace('/', '.')))
            {
                return XDocument.Load(resStream, LoadOptions.PreserveWhitespace);
            }
        }

        private static Stream LoadResource(string resourceName)
        {
            var baseType = typeof(DatenuebermittlerTests2015);
            var asm = baseType.Assembly;
            var resFileName = $"Daten.due2015.{resourceName}";
            var resStream = asm.GetManifestResourceStream(baseType, resFileName);
            Assert.NotNull(resStream);
            return resStream;
        }
    }
}
