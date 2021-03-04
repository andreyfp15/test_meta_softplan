using TestMetaSoftplan.Domain;
using Xunit;

namespace TestMetaSoftplan.Tests
{
    public class UnitTest
    {
        [Fact]
        public void TestRepositoryGitHub()
        {
            var repository = new GitHub().ReturnGitHubRepository();
            Assert.Equal("https://github.com/andreyfp15/test_meta_softplan", repository);
        }

        [Fact]
        public void TestReturnFees()
        {
            decimal fees = new Fees().ReturnFees();
            Assert.Equal(0.01m, fees);
        }

        [Fact]
        public void TestCalcFees()
        {
            decimal calc = new Fees().ReturnCalcFees(100, new Fees().ReturnFees(), 5);
            Assert.Equal(105.10m, calc);
        }

    }
}
