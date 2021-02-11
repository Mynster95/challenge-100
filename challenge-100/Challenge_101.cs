using System.Collections.Generic;
using System.Linq;

namespace challenge_100
{
    public class Challenge_101 : IChallenge_101
    {
        public Challenge_101() { }


        public IEnumerable<int> FindMinMax(IEnumerable<int> numbers)
        {

            if (numbers.Count().Equals(0)) return new List<int> { 0, 0 };

            if (numbers.Count().Equals(1))
            {
                if (numbers.FirstOrDefault() > 0) return new List<int> { numbers.FirstOrDefault(), numbers.FirstOrDefault() };

                return new List<int> { numbers.FirstOrDefault(), 0 };

            }

            List<int> resultArray = new List<int>
            {
                numbers.Min(),
                numbers.Max()
            };

            return resultArray;
        }

    }
}
