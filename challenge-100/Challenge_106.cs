using System;
using System.Collections.Generic;
using System.Linq;

namespace challenge_100
{
    public class Challenge_106 : IChallenge_106
    {
        public Challenge_106() { }
        
        public string AlphabetIndex(string input) 
        {
            var letters = input.ToUpper().Where(char.IsLetter);
            var returnString = "";

            foreach (var c in letters) 
            {
                // Ascii representation of uppercase characters are from 65-90, hence if you subtract the representation of the ascii value with 64, 
                // you'll get the alphabetic index.
                returnString += (c - 64) + " ";
            }
            if (returnString.Length > 1) 
            {
                return returnString.Remove(returnString.Length - 1);
            }
            return returnString;

            
        }

    }
}
