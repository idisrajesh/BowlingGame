using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Game: IGame
    {
        private int[] roll = new int[20];
        private int currentRoll = 0;

        public void Roll (int pin)
        {
            roll[currentRoll++] += pin;

        }

        public int GetScore()
        {
            int score = 0;
            int i = 0;
            for(int frame=0;frame < 10; frame++)
            {
                if (IsStrike(i))
                {
                    score += GetStrikeScore(i);
                    i += 1;
                }
                else if (IsSpare(i))
                {
                    score = GetSpareScore(score, i);
                    i += 2;
                }

                else
                {
                    score += GetStandardScore(i);
                    i += 2;
                }

               
            }
            return score;
        }

        
        private bool IsStrike(int i)
        {
            return roll[i] == 10;
        }
        private bool IsSpare(int i)
        {
            return roll[i] + roll[i + 1] == 10;
        }
        private int GetStandardScore(int i)
        {
            return roll[i] + roll[i + 1];
        }

        private int GetSpareScore(int score, int i)
        {
            score += roll[i] + roll[i + 1] + roll[i + 2];
            return score;
        }
        private int GetStrikeScore(int i)
        {
            return roll[i] + roll[i + 1] + roll[i + 2];
        }





    }

}
