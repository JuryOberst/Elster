using System;
using System.Collections.Generic;

using Dataline.Elster.Anmeldung;
using Dataline.Elster.Basis;
using Dataline.Elster.Datenabholung;
using Dataline.Elster.Datenuebermittler2014;
using Dataline.Elster.Datenuebermittler2015;
using Dataline.Elster.Lohn;

using Xunit;

namespace Dataline.Elster.Test
{
    public class SchemaResourceTests
    {
        [Theory]
        [InlineData(typeof(BasisResourceProvider))]
        [InlineData(typeof(AnmeldungResourceProvider))]
        [InlineData(typeof(LohnResourceProvider))]
        [InlineData(typeof(DatenabholungResourceProvider))]
        [InlineData(typeof(Datenuebermittler2014ResourceProvider))]
        [InlineData(typeof(Datenuebermittler2015ResourceProvider))]
        [InlineData(typeof(LohnResourceProvider))]
        public void LoadableTest(Type resourceProviderType)
        {
            var resourceProvider = (IResourceProvider)Activator.CreateInstance(resourceProviderType);
            Assert.NotEqual(0, resourceProvider.FileNames.Count);
            Assert.NotEqual(0, resourceProvider.BaseFileNames.Count);
            Assert.All(resourceProvider.FileNames, fileName =>
            {
                using (var stream = resourceProvider.CreateStream(fileName))
                    Assert.NotNull(stream);
            });
            var fileNames = new HashSet<string>(resourceProvider.FileNames);
            Assert.All(resourceProvider.BaseFileNames, fileName => Assert.True(fileNames.Contains(fileName)));
        }

        [Fact]
        public void AnmeldungTest()
        {
            var resourceProvider = new AnmeldungResourceProvider();

            Assert.Throws<ArgumentOutOfRangeException>(() => resourceProvider.GetBaseFileNameAnmeldungssteuer(2003));
            Assert.Throws<ArgumentOutOfRangeException>(() => resourceProvider.GetBaseFileNameAnmeldungssteuer(2017));
            Assert.Throws<ArgumentOutOfRangeException>(() => resourceProvider.GetBaseFileNameAnmeldungssteuer(2011, 2));

            var fileNames = new HashSet<string>(resourceProvider.FileNames);

            Assert.True(fileNames.Contains(resourceProvider.GetBaseFileNameAnmeldungssteuer(2004)));
            Assert.True(fileNames.Contains(resourceProvider.GetBaseFileNameAnmeldungssteuer(2016)));
        }

        [Fact]
        public void UmsatzsteuerTest()
        {
            var resourceProvider = new AnmeldungResourceProvider();

            Assert.Throws<ArgumentOutOfRangeException>(() => resourceProvider.GetBaseFileNameUmsatzsteuer(2003, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => resourceProvider.GetBaseFileNameUmsatzsteuer(2017, 1));
            Assert.Throws<ArgumentOutOfRangeException>(() => resourceProvider.GetBaseFileNameUmsatzsteuer(2011, 3));

            var fileNames = new HashSet<string>(resourceProvider.FileNames);

            Assert.True(fileNames.Contains(resourceProvider.GetBaseFileNameUmsatzsteuer(2004, 1)));
            Assert.True(fileNames.Contains(resourceProvider.GetBaseFileNameUmsatzsteuer(2016, 1)));
            Assert.True(fileNames.Contains(resourceProvider.GetBaseFileNameUmsatzsteuer(2011, 2)));
        }
    }
}
