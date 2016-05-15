using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Drawing.Text;

namespace Test_Sniper
{
    public partial class FormMap : Form
    {
        public Map map;
        public Player player;
        public Crosshair crosshair;
        public FormMenu formMenu;

        public bool win;
        public bool keyPress;
        public bool nextLevel;
 
        public int level;
        public int timer;
        public int mapTime;
        public int difficulty;
        public System.Timers.Timer t;
        public SoundPlayer sniperPlayer;

        public FormMap()
        {
            InitializeComponent();
            map = new Map();
            formMenu = (FormMenu)ActiveForm;
            difficulty = (int)formMenu.currentDifficulty;
            player = new Player(difficulty);
            crosshair = formMenu.Crosshair;

            win = false;
            keyPress = false;
            nextLevel = false;

            level = 1;
            timer = 0;
            mapTime = 45;
            
            Cursor.Hide();
            sniperPlayer = new SoundPlayer(Properties.Resources.sniper_rifle);
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
            setFont();
            setTimer();
            backgroundWorkerTime.RunWorkerAsync();

            pictureBoxMap.Image = map.bitmapImg;
            map.drawEnemy();
            labelNext.Hide();
            labelLifes.Text = player.getLifes();
            labelScore.Text = player.getScore();
            labelTime.Text = mapTime.ToString();
            labelClock.Image = Properties.Resources.clock;
        }

        private void pictureBoxMap_Paint(object sender, PaintEventArgs e)
        {
            if (keyPress == false)
            {
                crosshair.Draw(e.Graphics);
            }
            Invalidate(true);
        }

        private void pictureBoxMap_MouseMove(object sender, MouseEventArgs e)
        {
            crosshair.currentPoint = new Point(e.X, e.Y);
            Invalidate(true);
        }

        private void pictureBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && keyPress == false)
            {
                sniperPlayer.Play();
                crosshair.currentPoint = new Point(e.X, e.Y - 70);
                pictureBoxMap.Refresh();

                if (map.Hit(e.Location))
                {
                    player.incrementHits();
                    if (player.checkHits())
                    {
                        level += 1;
                        if (level > 5)
                        {
                            player.updateScore(mapTime);
                            refreshScore();
                            win = true;
                            endGame();
                        }
                        else
                        {
                            player.updateScore(mapTime);    //Update the score with the time
                            labelNext.Show();   //Click Space to continue
                            nextLevel = true;   //Flag to know if the level is finished
                            map.setMap();   //Refresh the map
                            pictureBoxMap.Image = map.bitmapImg;

                            this.pictureBoxMap.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
                            this.pictureBoxMap.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseClick);

                            t.Enabled = false;  //Stop the timer  
                            mapTime = 45;   //Restart the map timer
                            timer = 0;  //Restart the enemy timer
                            refreshTimer(); //Show the new map timer
                        }
                    }
                    else
                    {
                        map.setMap();
                        pictureBoxMap.Image = map.bitmapImg;
                        map.drawEnemy();
                        timer = 0;
                    }
                }
                else
                {
                    player.losePoints();
                }
                refreshScore();
            }
        }

        private void pictureBoxMap_MouseHover(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void pictureBoxMap_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void labelNext_MouseHover(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void refreshScore()
        {
            labelScore.Text = player.getScore();
        }

        private void refreshTimer()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => refreshTimer()));
            }
            else
            {
                labelTime.Text = mapTime.ToString();
            }
        }

        public void refreshLifes()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => refreshLifes()));
            }
            else
            {
                labelLifes.Text = player.getLifes();
            }
        }

        private void t_Elapsed(object sender, EventArgs e)
        {
            timer++;
            mapTime--;
            if (timer % difficulty == 0)
            {
                map.setMap();
                pictureBoxMap.Image = map.bitmapImg;
                map.drawEnemy();
                timer = 0;
                player.loseLife();
                refreshLifes();
            }
            if (player.Lifes == 0 || mapTime == 0)
            {
                refreshScore();
                win = false;
                endGame();
            }
        }
        
        private void backgroundWorkerTime_DoWork(object sender, DoWorkEventArgs e)
        { 
            while (!backgroundWorkerTime.CancellationPending)
            {
                refreshTimer();
                Thread.Sleep(1000);
            }
            e.Cancel = true;
        }

        private void FormMap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'z')
            {
                keyPress = true;
            }
            if (e.KeyChar == 'x')
            {
                keyPress = false;
            }
            if (e.KeyChar == (char)32 && nextLevel)
            {
                map.nextLevel();
                map.setMap();
                pictureBoxMap.Image = map.bitmapImg;
                map.drawEnemy();

                this.pictureBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
                this.pictureBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseClick);

                t.Enabled = true;
                labelNext.Hide();
                nextLevel = false;
                Invalidate(true);
            }
        }

        public void endGame()
        {
            t.Enabled = false;
            this.pictureBoxMap.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
            this.pictureBoxMap.MouseClick -= new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseClick);

            FormDialog formDialog = new FormDialog();
            if (formDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                player.Name = formDialog.name;
                formMenu.addScore(Int32.Parse(player.getScore()), player.Name);
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Method for setting the font in the Map
        /// </summary>
        private void setFont()
        {
            labelNext.Font = CustomFont.menuFont;
            labelLifes.Font = CustomFont.statusFont;
            labelTime.Font = CustomFont.statusFont;
            labelScore.Font = CustomFont.statusFont;
        }

        /// <summary>
        /// Method for setting the timer in the Map
        /// </summary>
        public void setTimer()
        {
            t = new System.Timers.Timer();
            t.Enabled = true;
            t.Interval = 1000;
            t.Elapsed += new ElapsedEventHandler(t_Elapsed);
            t.Start();
        }

        /// <summary>
        /// Zoom in and zoom out with mouse wheel 
        /// </summary>
        //protected override void OnMouseWheel(MouseEventArgs e)
        //{
        //    // Override OnMouseWheel event, for zooming in/out with the scroll wheel
        //    if (pictureBoxMap.Image != null)
        //    {
        //        // If the mouse wheel is moved forward (Zoom in)
        //        if (e.Delta > 0)
        //        {
        //            // Check if the pictureBox dimensions are in range (5 is the minimum and maximum zoom level)
        //            if ((pictureBoxMap.Width < (5 * this.Width)) && (pictureBoxMap.Height < (5 * this.Height)))
        //            {
        //                // Change the size of the picturebox, multiply it by the ZOOMFACTOR
        //                pictureBoxMap.Width = (int)(pictureBoxMap.Width * 1.25);
        //                pictureBoxMap.Height = (int)(pictureBoxMap.Height * 1.25);

        //                // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
        //                pictureBoxMap.Top = (int)(e.Y - 1.25 * (e.Y - pictureBoxMap.Top));
        //                pictureBoxMap.Left = (int)(e.X - 1.25 * (e.X - pictureBoxMap.Left));
        //            }
        //        }
        //        else
        //        {
        //            // Check if the pictureBox dimensions are in range (5 is the minimum and maximum zoom level)
        //            if ((pictureBoxMap.Width > (this.Width / 0.6)) && (pictureBoxMap.Height > (this.Height / 0.6)))
        //            {
        //                // Change the size of the picturebox, divide it by the ZOOMFACTOR
        //                pictureBoxMap.Width = (int)(pictureBoxMap.Width / 1.25);
        //                pictureBoxMap.Height = (int)(pictureBoxMap.Height / 1.25);

        //                // Formula to move the picturebox, to zoom in the point selected by the mouse cursor
        //                pictureBoxMap.Top = (int)(e.Y - 0.80 * (e.Y - pictureBoxMap.Top));
        //                pictureBoxMap.Left = (int)(e.X - 0.80 * (e.X - pictureBoxMap.Left));
        //            }
        //        }
        //    }
        //}
    }
}
