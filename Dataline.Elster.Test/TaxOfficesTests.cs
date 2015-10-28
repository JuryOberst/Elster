using System;
using System.Linq;

using Xunit;

namespace Dataline.Elster.Test
{
    public class TaxOfficesTests
    {
        [Fact]
        public void TestQueryInvalidTaxOffices()
        {
            var allTaxOffices = new TaxOffices(new StaticTaxOfficeProvider(), null);
            var info = allTaxOffices.Load(5110).Single();
            Assert.Equal("Finanzamt Essen-Nord (neu: NordOst)", info.Name);
            Assert.NotNull(info.ValidUntil);
            Assert.Equal(new DateTime(2012, 10, 16), info.ValidUntil);
        }

        [Fact]
        public void TestQueryDefaultForInvalidTaxOffice()
        {
            var taxOffices = TaxOffices.Active;
            var info = taxOffices.Load(5110).SingleOrDefault();
            Assert.Null(info);
        }

        [Fact]
        public void TestTaxOfficeChanges20141016()
        {
            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 10, 16));
                var info = taxOffices.Load(5129).SingleOrDefault();
                Assert.Null(info);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 10, 16));
                var info = taxOffices.Load(5129, true).SingleOrDefault();
                Assert.NotNull(info);
                Assert.Equal(5128, info.BufaNr);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 10, 15));
                var info = taxOffices.Load(5129).Single();
                Assert.Equal(new DateTime(2014, 10, 16), info.ValidUntil);
                Assert.NotNull(info.RedirectTo);
                Assert.Equal(new[] { 5128 }, info.RedirectTo);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 10, 15));
                var info = taxOffices.Load(5129, true).Single();
                Assert.Equal(5129, info.BufaNr);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 11, 30));
                var info = taxOffices.Load(2713).Single();
                Assert.NotNull(info.ValidUntil);
                Assert.Equal(new DateTime(2014, 12, 1), info.ValidUntil);
                Assert.Null(info.RedirectTo);
                Assert.True(info.SupportsElsterAnmeldung);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 11, 30));
                var info = taxOffices.Load(2713, true).Single();
                Assert.Equal(2713, info.BufaNr);
                Assert.True(info.SupportsElsterAnmeldung);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 12, 01));
                var info = taxOffices.Load(2713).SingleOrDefault();
                Assert.NotNull(info);
                Assert.Equal(new[] { 2743 }, info.RedirectTo);
                Assert.False(info.SupportsElsterAnmeldung);
            }

            {
                var taxOffices = new TaxOffices(new StaticTaxOfficeProvider(), new DateTime(2014, 12, 01));
                var info = taxOffices.Load(2713, true).Single();
                Assert.Equal(2743, info.BufaNr);
            }
        }
    }
}
