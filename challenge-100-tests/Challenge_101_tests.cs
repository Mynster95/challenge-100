using challenge_100;
using System.Collections.Generic;
using Xunit;

namespace challenge_100_tests
{
    public class Challenge_101_tests
    {
        private readonly Challenge_101 _challenge101 = new Challenge_101();

        public Challenge_101_tests() { }



        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5}, new int[] {1,5})]
        [InlineData(new int[] {2334454,5}, new int[] { 5, 2334454 })]
        [InlineData(new int[] { 1 }, new int[] { 1 , 1 })]
        public void FindMinMax(IEnumerable<int> numbers, IEnumerable<int> expected)
        {
            Assert.Equal(expected, _challenge101.FindMinMax(numbers));
        }
    }
}
