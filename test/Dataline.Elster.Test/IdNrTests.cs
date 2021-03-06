﻿// <copyright file="IdNrTests.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using Xunit;

namespace Dataline.Elster.Test
{
    public class IdNrTests
    {
        [Theory]
        [InlineData("02476291358")]
        public void TestTestIds(string idNr)
        {
            var test = new IdNr(idNr);
            Assert.Equal(IdNrStatus.Ok, test.Status);
        }

        [Theory]
        [InlineData("71304527968")]
        [InlineData("60244195735")]
        [InlineData("23305869173")]
        [InlineData("45670312008")]
        public void TestRealIds(string idNr)
        {
            var test = new IdNr(idNr);
            Assert.Equal(IdNrStatus.Ok, test.Status);
        }
    }
}
