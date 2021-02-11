using challenge_100;
using System.Collections.Generic;
using Xunit;

namespace challenge_100_tests
{
    public class Challenge_103_tests
    {
        private readonly Challenge_103 _challenge103 = new Challenge_103();

        public Challenge_103_tests(){}



        [Theory]
        [InlineData("hello",true)]
        [InlineData("HELLO",true)]
        [InlineData("Hello", false)]
        [InlineData("ketcHUp", false)]
        public void SameCase(string letters, bool expected)
        { 
            Assert.Equal(expected, _challenge103.SameCase(letters));
        }

        



    }
}
