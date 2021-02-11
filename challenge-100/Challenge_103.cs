using System.Collections.Generic;
using System.Linq;

namespace challenge_100
{
    public class Challenge_103 : IChallenge_103
    {
        public Challenge_103() { }

        public bool SameCase(string letters) 
        {
            return letters.ToLower() == letters || letters.ToUpper() == letters;
        }
       

    }
}
