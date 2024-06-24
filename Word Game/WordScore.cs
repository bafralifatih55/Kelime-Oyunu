using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class WordScore
    {
private int numberOfLetters;
        private int remainingPoints;

        public WordScore(int numberOfLetters)
        {
            this.numberOfLetters= numberOfLetters;
            remainingPoints = numberOfLetters * 10;
        }

        public int RemainingPoints => remainingPoints;

        public void DeductPoint()
        {
            if (remainingPoints>=10) 
            {
                remainingPoints -= 10;
            }
        }
    }
}
