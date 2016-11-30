// <copyright file="TaxNumberTests.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System.Collections.Generic;

using Xunit;

namespace Dataline.Elster.Test
{
    /// <summary>
    /// Zusammenfassungsbeschreibung für UnitTest1
    /// </summary>
    public class TaxNumberTests
    {
        private readonly TaxOffices _defaultTaxOffices = new TaxOffices(new StaticTaxOfficeProvider());

        [Fact]
        public void TestTaxNumberMethodModified11()
        {
            var taxNumber = new TaxNumber(_defaultTaxOffices, "2799081508152")
            {
                AllowTestTaxOffices = true,
            };
            Assert.Equal(Province.RheinlandPfalz, taxNumber.Province);
            Assert.Equal(TaxNumberStatus.Ok, taxNumber.Status);
        }

        [Fact]
        public void TestTaxNumberMethod2()
        {
            var taxNumber = new TaxNumber(_defaultTaxOffices, "2866081508156")
            {
                AllowTestTaxOffices = true,
            };
            Assert.Equal(Province.BadenWuerttemberg, taxNumber.Province);
            Assert.Equal(TaxNumberStatus.Ok, taxNumber.Status);
        }

        [Fact]
        public void TestTaxNumberMethod11_Bayern()
        {
            var taxNumber = new TaxNumber(_defaultTaxOffices, "9198081508152")
            {
                AllowTestTaxOffices = true,
            };
            Assert.Equal(Province.Bayern, taxNumber.Province);
            Assert.Equal(TaxNumberStatus.Ok, taxNumber.Status);
        }

        [Fact]
        public void TestTaxNumberMethod11_NRW()
        {
            var testTaxNumbers = new[]
            {
                "5400081508159",
                "5500081508151",
                "5600081508154",
            };
            foreach (var testTaxNumber in testTaxNumbers)
            {
                var taxNumber = new TaxNumber(_defaultTaxOffices, testTaxNumber)
                {
                    AllowTestTaxOffices = true,
                };
                Assert.Equal(Province.NordrheinWestfalen, taxNumber.Province);
                Assert.Equal(TaxNumberStatus.Ok, taxNumber.Status);
            }
        }

        [Fact]
        public void TestTaxNumberCustomerBadenWuerttemberg()
        {
            var testTaxNumbers = new[]
            {
                "2870019345500",
                "2850012312346",
            };
            foreach (var testTaxNumber in testTaxNumbers)
            {
                var taxNumber = new TaxNumber(_defaultTaxOffices, testTaxNumber)
                {
                    AllowTestTaxOffices = true,
                };
                Assert.Equal(Province.BadenWuerttemberg, taxNumber.Province);
                Assert.Equal(TaxNumberStatus.Ok, taxNumber.Status);
            }
        }

        [Fact]
        public void TestTaxNumberParseBadenWuerttemberg()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "66815/08156", "2866081508156" },
            };
            TestTaxNumberParse(numbers, Province.BadenWuerttemberg);
        }

        [Fact]
        public void TestTaxNumberParseBayern()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "198/815/08152", "9198081508152" },
                { "296/815/08153", "9296081508153" },
            };
            TestTaxNumberParse(numbers, Province.Bayern);
        }

        [Fact]
        public void TestTaxNumberParseBerlin()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "97/815/08154", "1197081508154" },
                { "16/273/60627", "1116027360627" },
            };
            TestTaxNumberParse(numbers, Province.Berlin);
        }

        [Fact]
        public void TestTaxNumberParseBrandenburg()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "098/815/08157", "3098081508157" },
            };
            TestTaxNumberParse(numbers, Province.Brandenburg);
        }

        [Fact]
        public void TestTaxNumberParseBremen()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "97 123 01233", "2497012301233" },
            };
            TestTaxNumberParse(numbers, Province.Bremen);
        }

        [Fact]
        public void TestTaxNumberParseHamburg()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "41/815/08154", "2241081508154" },
            };
            TestTaxNumberParse(numbers, Province.Hamburg);
        }

        [Fact]
        public void TestTaxNumberParseHessen()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "053 815 08158", "2653081508158" },
            };
            TestTaxNumberParse(numbers, Province.Hessen);
        }

        [Fact]
        public void TestTaxNumberParseMecklenburgVorpommern()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "098/815/08157", "4098081508157" },
            };
            TestTaxNumberParse(numbers, Province.MecklenburgVorpommern);
        }

        [Fact]
        public void TestTaxNumberParseNiedersachsen()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "88/815/08158", "2388081508158" },
                { "27/120/12296", "2327012012296" }
            };
            TestTaxNumberParse(numbers, Province.Niedersachsen);
        }

        [Fact]
        public void TestTaxNumberParseNRW()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "400/8150/8159", "5400081508159" },
                { "500/8150/8151", "5500081508151" },
                { "600/8150/8154", "5600081508154" },
            };
            TestTaxNumberParse(numbers, Province.NordrheinWestfalen);
        }

        [Fact]
        public void TestTaxNumberParseRheinlandPfalz()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "99/815/08152", "2799081508152" },
            };
            TestTaxNumberParse(numbers, Province.RheinlandPfalz);
        }

        [Fact]
        public void TestTaxNumberParseSaarland()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "096/815/08187", "1096081508187" },
            };
            TestTaxNumberParse(numbers, Province.Saarland);
        }

        [Fact]
        public void TestTaxNumberParseSachsen()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "248/815/08156", "3248081508156" },
            };
            TestTaxNumberParse(numbers, Province.Sachsen);
        }

        [Fact]
        public void TestTaxNumberParseSachsenAnhalt()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "198/815/08152", "3198081508152" },
            };
            TestTaxNumberParse(numbers, Province.SachsenAnhalt);
        }

        [Fact]
        public void TestTaxNumberParseSchleswigHolstein()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "38/815/08154", "2138081508154" },
            };
            TestTaxNumberParse(numbers, Province.SchleswigHolstein);
        }

        [Fact]
        public void TestTaxNumberParseThueringen()
        {
            var numbers = new Dictionary<string, string>()
            {
                { "198/815/08152", "4198081508152" },
            };
            TestTaxNumberParse(numbers, Province.Thueringen);
        }

        [Fact]
        public void TestTaxNumberErrorTooLong()
        {
            var test = new TaxNumber("23 154 546546", Province.Niedersachsen);
            Assert.False(test.Valid);
            Assert.Equal(TaxNumberStatus.InvalidLength, test.Status);
        }

        private void TestTaxNumberParse(IEnumerable<KeyValuePair<string, string>> numbers, Province province)
        {
            foreach (var number in numbers)
            {
                var inputNumber = number.Key;
                var taxNumber = TaxNumber.Parse(_defaultTaxOffices, inputNumber, province);
                taxNumber.AllowTestTaxOffices = true;
                Assert.Equal(province, taxNumber.Province);
                Assert.Equal(TaxNumberStatus.Ok, taxNumber.Status);
                Assert.Equal(number.Value, taxNumber.Number);
                Assert.Equal(inputNumber, taxNumber.ToString());
            }
        }
    }
}
