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
        public void TestRealIds(string idNr)
        {
            var test = new IdNr(idNr);
            Assert.Equal(IdNrStatus.Ok, test.Status);
        }
    }
}
