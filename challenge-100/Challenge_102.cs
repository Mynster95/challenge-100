using System.Collections.Generic;
using System.Linq;

namespace challenge_100
{
    public class Challenge_102 : IChallenge_102
    {
        public Challenge_102() { }


        // Jeg antager at en person kun kan have ét fornavn og ét hovednavn
        public string NameShuffle(string names) 
        {
            if (names == "") return "";

            if (!(names.Contains(" "))) return names;


            var namesSplit = names.Split(" ");

            return namesSplit[1] + " " + namesSplit[0];
        }
       

    }
}
