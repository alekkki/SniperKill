using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Test_Sniper
{
    public class Player
    {
        public int Hits { get; set; }
        public int Lifes { get; set; }
        public string Name { get; set; }
        public Score Score { get; set; }

        public Player(int d)
        {
            Hits = 0;
            Lifes = 4;
            Score = new Score(d);
        }

        public void incrementHits()
        {
            Hits++;
            Score.incrementScore();
        }

        public void losePoints()
        {
            Score.decrementScore();
        }

        public void loseLife()
        {
            Lifes--;
        }

        public void updateScore(int time)
        {
            Score.addTime(time);
        }

        public bool checkHits()
        {
            if (Hits == 8)
            {
                Hits = 0;
                return true;
            }
            return false;
        }

        public string getLifes()
        {
            return string.Format("+ {0}", Lifes);
        }

        public string getScore()
        {
            return Score.ToString();
        }
    }
}