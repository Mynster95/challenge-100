using challenge_100;
using System;
using System.Collections.Generic;
using Xunit;

namespace challenge_100_tests
{
    public class Challenge_106_tests
    {
        private readonly Challenge_106 _challenge106 = new Challenge_106();

        public Challenge_106_tests(){}


            

        [Theory]
        [InlineData("Wow, does that work?", "23 15 23 4 15 5 19 20 8 1 20 23 15 18 11")]
        [InlineData("The river stole the gods.","20 8 5 18 9 22 5 18 19 20 15 12 5 20 8 5 7 15 4 19")]
        [InlineData("We have a lot of rain in June.","23 5 8 1 22 5 1 12 15 20 15 6 18 1 9 14 9 14 10 21 14 5")]
        public void AlphabetIndexGivenTest1ReturnsTest1(string value, string expected)
        {
            Assert.Equal(expected, _challenge106.AlphabetIndex(value));
        }
    }
}
