using System;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

using Dataline.Elster.Anmeldung;

using Xunit;

namespace Dataline.Elster.Test.ElsterAnmeldung
{
    public class ElsterAnmeldungTests : ElsterDocumentValidation
    {
        private static readonly Regex YearRegex = new Regex(@"_([0-9]{4})(_((erstes)|(zweites))_Halbjahr)?\.", RegexOptions.Compiled);

        [Theory(DisplayName = "Lohnsteueranmeldung")]
        [InlineData("LSTA_Bayern_2004.xml")]
        [InlineData("LSTA_Bayern_2005.xml")]
        [InlineData("LSTA_Bayern_2006.xml")]
        [InlineData("LSTA_Bayern_2007.xml")]
        [InlineData("LSTA_Bayern_2008.xml")]
        [InlineData("LSTA_Bayern_2009.xml")]
        [InlineData("LSTA_Bayern_2010.xml")]
        [InlineData("LSTA_Bayern_2011.xml")]
        [InlineData("LSTA_Bayern_2012.xml")]
        [InlineData("LSTA_Bayern_2013.xml")]
        [InlineData("LSTA_Bayern_2014.xml")]
        [InlineData("LSTA_Bayern_2015.xml")]
        [InlineData("LSTA_Bayern_2016.xml")]
        public void TestDeserializeLSTA(string relativeFileName)
        {
            var yearMonth = GetYearMonth(relativeFileName);
            var provider = new AnmeldungResourceProvider();
            var doc = Load(relativeFileName);
            TestDocument(doc, provider, provider.GetBaseFileNameAnmeldungssteuer(yearMonth.Item1, yearMonth.Item2));
        }

        [Theory(DisplayName = "Umsatzsteuervoranmeldung")]
        [InlineData("USTVA_2004.xml")]
        [InlineData("USTVA_2005.xml")]
        [InlineData("USTVA_2006.xml")]
        [InlineData("USTVA_2007.xml")]
        [InlineData("USTVA_2008.xml")]
        [InlineData("USTVA_2009.xml")]
        [InlineData("USTVA_2010_erstes_Halbjahr.xml")]
        [InlineData("USTVA_2010_zweites_Halbjahr.xml")]
        [InlineData("USTVA_2011_erstes_Halbjahr.xml")]
        [InlineData("USTVA_2011_zweites_Halbjahr.xml")]
        [InlineData("USTVA_2012.xml")]
        [InlineData("USTVA_2013.xml")]
        [InlineData("USTVA_2014.xml")]
        [InlineData("USTVA_2015.xml")]
        [InlineData("USTVA_2016.xml")]
        [InlineData("USTVA_Df_2004.xml")]
        [InlineData("USTVA_Df_2005.xml")]
        [InlineData("USTVA_Df_2006.xml")]
        [InlineData("USTVA_Df_2007.xml")]
        [InlineData("USTVA_Df_2008.xml")]
        [InlineData("USTVA_Df_2009.xml")]
        [InlineData("USTVA_Df_2010.xml")]
        [InlineData("USTVA_Df_2011.xml")]
        [InlineData("USTVA_Df_2012.xml")]
        [InlineData("USTVA_Df_2013.xml")]
        [InlineData("USTVA_Df_2014.xml")]
        [InlineData("USTVA_Df_2015.xml")]
        [InlineData("USTVA_Df_2016.xml")]
        [InlineData("USTVA_SoVZ_2004.xml")]
        [InlineData("USTVA_SoVZ_2005.xml")]
        [InlineData("USTVA_SoVZ_2006.xml")]
        [InlineData("USTVA_SoVZ_2007.xml")]
        [InlineData("USTVA_SoVZ_2008.xml")]
        [InlineData("USTVA_SoVZ_2009.xml")]
        [InlineData("USTVA_SoVZ_2010.xml")]
        [InlineData("USTVA_SoVZ_2011.xml")]
        [InlineData("USTVA_SoVZ_2012.xml")]
        [InlineData("USTVA_SoVZ_2013.xml")]
        [InlineData("USTVA_SoVZ_2014.xml")]
        [InlineData("USTVA_SoVZ_2015.xml")]
        [InlineData("USTVA_SoVZ_2016.xml")]
        public void TestDeserializeUSTVA(string relativeFileName)
        {
            var yearMonth = GetYearMonth(relativeFileName);
            var provider = new AnmeldungResourceProvider();
            var doc = Load(relativeFileName);
            TestDocument(doc, provider, provider.GetBaseFileNameUmsatzsteuer(yearMonth.Item1, yearMonth.Item2));
        }

        private static XDocument Load(string relativeFileName)
        {
            var asm = typeof(ElsterAnmeldungTests).Assembly;
            var resFileName = $"Daten.{relativeFileName.Replace('/', '.')}";
            using (var resStream = asm.GetManifestResourceStream(typeof(ElsterAnmeldungTests), resFileName))
            {
                Assert.NotNull(resStream);
                return XDocument.Load(resStream);
            }
        }

        private static Tuple<int, int> GetYearMonth(string fileName)
        {
            var match = YearRegex.Match(fileName);
            if (!match.Success)
                throw new InvalidOperationException("File name doesn't match regular expression for extraction of year and month.");
            var year = match.Groups[1].Value;
            var month = match.Groups[3].Value;
            var yearInt = XmlConvert.ToInt32(year);
            int monthInt;
            if (!string.IsNullOrEmpty(month))
            {
                switch (month)
                {
                    case "erstes":
                        monthInt = 1;
                        break;
                    case "zweites":
                        monthInt = 7;
                        break;
                    default:
                        throw new InvalidOperationException($"Unexpected month value {month}");
                }
            }
            else
            {
                monthInt = 1;
            }

            monthInt = (yearInt == 2011 && monthInt > 1) ? 2 : 1;
            return Tuple.Create(yearInt, monthInt);
        }
    }
}
