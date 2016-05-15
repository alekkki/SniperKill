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

namespace Test_Sniper
{
    public class Map
    {
        public int level;
        public Enemy enemy;
        public Bitmap bitmapImg { get; set; }
        public Graphics g;

        public Map()
        {
            level = 1;
            setMap();
            enemy = new Enemy();
            enemy.setEnemies(level);
            g = null;
        }

        public void drawEnemy()
        {
            g = Graphics.FromImage(bitmapImg);
            enemy.Draw(g);
        }

        public bool Hit(Point position)
        {
            return enemy.isHit(position);
        }

        public void nextLevel()
        {
            if (level < 5)
            {
                level += 1;
                enemy.setEnemies(level);
            }
        }

        public void setMap()
        {
            switch (level)
            {
                case 1:
                    bitmapImg = new Bitmap(Properties.Resources.map1);
                    break;
                case 2:
                    bitmapImg = new Bitmap(Properties.Resources.map2);
                    break;
                case 3:
                    bitmapImg = new Bitmap(Properties.Resources.map3);
                    break;
                case 4:
                    bitmapImg = new Bitmap(Properties.Resources.map4);
                    break;
                case 5:
                    bitmapImg = new Bitmap(Properties.Resources.map5);
                    break;
                default:
                    bitmapImg = new Bitmap(Properties.Resources.map1);
                    break;
            }  
        }
    }
}
