using Xunit;

namespace Dataline.Elster.Test
{
    public class IdNrTests
    {
        private static readonly string[] _realIdNrs = {
            "71304527968",
            "60244195735",
            "23305869173",
        };

        private static readonly string[] _testIdNrs = {
            "02476291358",
        };

        [Fact]
        public void TestTestIds()
        {
            foreach (var id in _testIdNrs)
            {
                var test = new IdNr(id);
                Assert.Equal(IdNrStatus.Ok, test.Status);
            }
        }

        [Fact]
        public void TestRealIds()
        {
            foreach (var id in _realIdNrs)
            {
                var test = new IdNr(id);
                Assert.Equal(IdNrStatus.Ok, test.Status);
            }
        }
    }
}
