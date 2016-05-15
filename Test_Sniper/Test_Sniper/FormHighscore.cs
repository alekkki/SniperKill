using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace Test_Sniper
{
    public partial class FormHighscore : Form
    {
        public SoundPlayer hoverPlayer;
        public SoundPlayer clickPlayer;

        public FormHighscore()
        {
            InitializeComponent();
            hoverPlayer = new SoundPlayer(Properties.Resources._switch);
            clickPlayer = new SoundPlayer(Properties.Resources.click);

            setFont();
            startScores();
        }

        private void hoverSound(object sender, EventArgs e)
        {
            hoverPlayer.Play();
        }

        private void clickSound(object sender, EventArgs e)
        {
            clickPlayer.Play();
        }

        private void labelBack_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void startScores()
        {
            try
            {
                StreamReader reader = File.OpenText("scores.txt");
                int rows = 1;
                StringBuilder sb = new StringBuilder();
                while (!reader.EndOfStream)
                {
                    if (rows > 10)
                    {
                        break;
                    }
                    string[] split = reader.ReadLine().Split(null);
                    sb.AppendLine(string.Format("{0} {1}", split[0], split[1]));
                    rows++;
                }
                reader.Close();
                labelScores.Text = sb.ToString();
            }
            catch (IOException e)
            {
                this.Show();
            }
        }

        /// <summary>
        /// Method for setting the font in the Highscore
        /// </summary>
        public void setFont()
        {
            labelTitle.Font = CustomFont.largeFont;
            labelNumbers.Font = CustomFont.mediumFont;
            labelScores.Font = CustomFont.mediumFont;
            labelBack.Font = CustomFont.smallFont;
        }
    }
}
