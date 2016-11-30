// <copyright file="StaticTaxOfficeProviderTests.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Linq;

using Xunit;

namespace Dataline.Elster.Test
{
    public class StaticTaxOfficeProviderTests
    {
        [Fact]
        public void TestRename()
        {
            var provider = new StaticTaxOfficeProvider();
            Assert.Equal("Zwickau-Land", provider.Query(new DateTime(2011, 1, 6)).Single(x => x.BufaNr == 3227).Name);
            Assert.Equal("Finanzamt Zwickau", provider.Query(new DateTime(2011, 1, 7)).Single(x => x.BufaNr == 3227).Name);
        }

        [Fact]
        public void TestCreate()
        {
            var provider = new StaticTaxOfficeProvider();
            Assert.Equal(0, provider.Query(new DateTime(2011, 1, 7)).Count(x => x.BufaNr == 3226));
            Assert.Equal(1, provider.Query(new DateTime(2011, 1, 6)).Count(x => x.BufaNr == 3226));
        }

        [Fact]
        public void TestComplexEssenNord()
        {
            var provider = new StaticTaxOfficeProvider();
            Assert.Equal("Essen-Nord", provider.Query(new DateTime(2007, 1, 1)).Single(x => x.BufaNr == 5110).Name);
            Assert.Equal(0, provider.Query(new DateTime(2007, 12, 1)).Count(x => x.BufaNr == 5110));
            Assert.Equal("Essen-Nord (neu: NordOst)", provider.Query(new DateTime(2008, 2, 25)).Single(x => x.BufaNr == 5110).Name);
            Assert.Equal("Finanzamt Essen-Nord (neu: NordOst)", provider.Query(new DateTime(2008, 12, 12)).Single(x => x.BufaNr == 5110).Name);
            Assert.Equal(0, provider.Query(new DateTime(2012, 10, 16)).Count(x => x.BufaNr == 5110));
        }
    }
}
