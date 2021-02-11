using challenge_100;
using System;
using System.Collections.Generic;
using Xunit;

namespace challenge_100_tests
{
    public class Challenge_105_tests
    {
        private readonly Challenge_105 _challenge105 = new Challenge_105();

        public Challenge_105_tests(){}


        [Fact]

        public void MonthNameGiven0ReturnsException()
        {
            var value = 0;

            Assert.Throws<InvalidOperationException>(() => _challenge105.MonthName(value));

        }

        [Theory]
        [InlineData(3,"March")]
        [InlineData(12, "December")]
        [InlineData(6, "June")]
        public void MonthName(int value, string expected)
        {
            Assert.Equal(expected, _challenge105.MonthName(value));
        }   
    }
}
