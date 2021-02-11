using challenge_100;
using System.Collections.Generic;
using Xunit;

namespace challenge_100_tests
{
    public class Challenge_104_tests
    {
        private readonly Challenge_104 _challenge104 = new Challenge_104();

        public Challenge_104_tests(){}


        [Theory]
        [InlineData("Algorism",true)]
        [InlineData("PasSword", false)]
        [InlineData("Consecutive", false)]
        public void IsIsogram(string letters, bool expected)
        {
            Assert.Equal(expected, _challenge104.IsIsogram(letters));
        }
    }
}
