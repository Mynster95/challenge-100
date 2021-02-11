using challenge_100;
using System.Collections.Generic;
using Xunit;

namespace challenge_100_tests
{
    public class Challenge_102_tests
    {
        private readonly Challenge_102 _challenge102 = new Challenge_102();

        public Challenge_102_tests(){}



        [Theory]
        [InlineData("Donald Trump","Trump Donald")]
        [InlineData("Rosie O'Donnell", "O'Donnell Rosie")]
        [InlineData("Seymour Butts", "Butts Seymour")]
        public void NameShuffle(string name, string expected)
        {
            Assert.Equal(expected, _challenge102.NameShuffle(name));
        }
    }
}
