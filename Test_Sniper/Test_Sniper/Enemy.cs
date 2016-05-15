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
    public class Enemy
    {
        public int Size { get; set; }
        public int Radius { get; set; }
        public Point drawPoint { get; set; }
        public Point enemyPosition { get; set; }
        public Random random;
        public List<Image> images;
        public Dictionary<Point, int> positions;

        public Enemy()
        {
            Size = 0;
            Radius = 0;
            drawPoint = new Point();
            enemyPosition = new Point();
            random = new Random();
            images = new List<Image>();
            setImages();
            positions = new Dictionary<Point, int>();
        }

        public void selectEnemy()
        {
            int i = random.Next(positions.Count);
            Size = positions.Values.ElementAt(i);
            Radius = Size / 4;
            drawPoint = positions.Keys.ElementAt(i);

            enemyPosition = setEnemyPoint(drawPoint);
        }

        public Image selectImage()
        {
            int i = random.Next(images.Count);
            return images[i];
        }

        public void Draw(Graphics g)
        {
            selectEnemy();
            g.DrawImage(selectImage(), drawPoint.X, drawPoint.Y, Size, Size);
        }

        public Point setEnemyPoint(Point drawPoint)
        {
            return new Point((drawPoint.X / 2) + Radius, (drawPoint.Y / 2) + Radius);
        }

        public bool isHit(Point position)
        {
            if(Math.Abs(position.X - enemyPosition.X) < Radius && Math.Abs(position.Y - enemyPosition.Y) < Radius)
            {
                return true;
            }
            return false;
        }

        public void setImages()
        {
            images.Add(Properties.Resources.teror1);
            images.Add(Properties.Resources.teror2);
            images.Add(Properties.Resources.teror3);
            images.Add(Properties.Resources.teror1Reverse);
            images.Add(Properties.Resources.teror2Reverse);
            images.Add(Properties.Resources.teror3Reverse);
        }

        public void setEnemies(int level)
        {
            switch (level)
            {
                case 1:
                    positions.Clear();
                    positions.Add(new Point(125, 355), 120);
                    positions.Add(new Point(199, 537), 120);
                    positions.Add(new Point(649, 371), 80);
                    positions.Add(new Point(1258, 404), 40);
                    positions.Add(new Point(1026, 388), 50);
                    positions.Add(new Point(1428, 507), 100);
                    positions.Add(new Point(1348, 205), 50);
                    positions.Add(new Point(870, 272), 50);
                    positions.Add(new Point(1302, 405), 40);
                    break;
                case 2:
                    positions.Clear();
                    positions.Add(new Point(180, 535), 100);
                    positions.Add(new Point(534, 488), 70);
                    positions.Add(new Point(658, 788), 100);
                    positions.Add(new Point(456, 661), 90);
                    positions.Add(new Point(170, 806), 100);
                    positions.Add(new Point(970, 517), 120);
                    positions.Add(new Point(1570, 634), 120);
                    positions.Add(new Point(1396, 488), 50);
                    positions.Add(new Point(1312, 473), 50);
                    positions.Add(new Point(1208, 462), 50);
                    break;
                case 3:
                    positions.Clear();
                    positions.Add(new Point(450, 393), 100);
                    positions.Add(new Point(84, 381), 120);
                    positions.Add(new Point(534, 590), 100);
                    positions.Add(new Point(840, 514), 120);
                    positions.Add(new Point(1178, 466), 50);
                    positions.Add(new Point(644, 502), 80);
                    positions.Add(new Point(1792, 506), 120);
                    positions.Add(new Point(1596, 358), 60);
                    positions.Add(new Point(974, 350), 70);
                    break;
                case 4:
                    positions.Clear();
                    positions.Add(new Point(1579, 300), 100);
                    positions.Add(new Point(1510, 105), 80);
                    positions.Add(new Point(1192, 386), 80);
                    positions.Add(new Point(790, 225), 80);
                    positions.Add(new Point(576, 490), 120);
                    positions.Add(new Point(302, 260), 100);
                    positions.Add(new Point(400, 64), 80);
                    positions.Add(new Point(52, 464), 120);
                    break;
                case 5:
                    positions.Clear();
                    positions.Add(new Point(810, 524), 80);
                    positions.Add(new Point(1008, 488), 80);
                    positions.Add(new Point(1766, 576), 120);
                    positions.Add(new Point(130, 122), 120);
                    positions.Add(new Point(1126, 608), 80);
                    positions.Add(new Point(636, 794), 120);
                    positions.Add(new Point(614, 366), 80);
                    positions.Add(new Point(1468, 285), 80);
                    break;
                default:
                    positions.Clear();
                    break;
            }
        }
    }
}
