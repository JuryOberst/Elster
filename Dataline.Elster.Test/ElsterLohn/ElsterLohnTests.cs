using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using Dataline.Elster.Lohn;

using JetBrains.Annotations;

using Xunit;

namespace Dataline.Elster.Test.ElsterLohn
{
    public class ElsterLohnTests
    {
        [Theory]
        [InlineData("ELO_DatenLieferung_LStB_201001_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201101_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201201_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201301_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201302_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201401_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201501_01.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201601_Neu.xml")]
        [InlineData("ELO_DatenLieferung_LStB_201601_Korrektur.xml")]
        [InlineData("ELO_DatenLieferung_LStBStorno_v1_Storno.xml")]
        [InlineData("protokoll/ELO_Protokoll_03_01.xml")]
        [InlineData("protokoll/ELO_Protokoll_03_02.xml")]
        [InlineData("protokoll/ELO_Protokoll_03_03.xml")]
        [InlineData("protokoll/ELO_Protokoll_04_01.xml")]
        [InlineData("protokoll/ELO_Protokoll_05_01.xml")]
        [InlineData("protokoll/ELO_Protokoll_05_02.xml")]
        [InlineData("protokoll/ELO_Protokoll_05_03.xml")]
        [InlineData("protokoll/ELO_ProtokollAnforderung_02_01.xml")]
        [InlineData("protokoll/ELO_ProtokollAnforderung_03.xml")]
        public void TestDeserialize(string relativeFileName)
        {
            var doc = Load(relativeFileName);
            var provider = new LohnResourceProvider();
            //provider.BaseFileNames
        }

        [NotNull]
        private static XDocument Load([NotNull] string relativeFileName)
        {
            var asm = typeof(ElsterLohnTests).Assembly;
            var resFileName = $"Daten.{relativeFileName.Replace('/', '.')}";
            using (var resStream = asm.GetManifestResourceStream(typeof(ElsterLohnTests), resFileName))
            {
                Assert.NotNull(resStream);
                return XDocument.Load(resStream);
            }
        }
    }
}
