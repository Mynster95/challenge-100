using System;
using System.Collections.Generic;
using System.Linq;

namespace challenge_100
{
    public class Challenge_105 : IChallenge_105
    {
        private enum Months {
            January,    
            February,   
            March,   
            April,     
            May,        
            June,       
            July,
            August,
            September,
            October,
            November,
            December
        }
        public Challenge_105() { }

        public string MonthName(int value) 
        {
            if (value > 0 && value < 13)
            {
                Months month = (Months)(value - 1);
                return month.ToString();
            }
            else throw new InvalidOperationException(value.ToString());
        }
       

    }
}
