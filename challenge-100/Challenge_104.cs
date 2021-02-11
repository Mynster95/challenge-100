using System.Collections.Generic;
using System.Linq;

namespace challenge_100
{
    public class Challenge_104 : IChallenge_104
    {
        public Challenge_104() { }

        public bool IsIsogram(string letters) 
        {

            var groupedLetters = letters.ToLower().Where(char.IsLetter).GroupBy(c => c).Select(g => new { Letter = g.Key, Count = g.Count() });

            foreach (var item in groupedLetters) 
            {
                if (item.Count > 1) return false;
            }

            return true;
        }
       

    }
}
