using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Sniper
{
    public class Score
    {
        public int score { get; set; }
        public int difficulty;

        public Score(int d)
        {
            score = 0;
            difficulty = 6 - d;
        }

        public void incrementScore()
        {
            score += (difficulty * 10);
        }

        public void decrementScore()
        {
            if (score - 10 < 0)
            {
                score = 0;
            }
            else
            {
                score -= 10;
            }
        }

        public void addTime(int time)
        {
            score += (time * 2);
        }

        public override string ToString()
        {
            return score.ToString();
        }
    }
}