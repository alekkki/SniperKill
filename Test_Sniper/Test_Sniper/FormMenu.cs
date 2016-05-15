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
using System.Drawing.Text;
using System.IO;

namespace Test_Sniper
{
    public partial class FormMenu : Form
    {
        public Crosshair Crosshair;
        public Difficulty currentDifficulty;

        public SoundPlayer hoverPlayer;
        public SoundPlayer clickPlayer;

        public enum Difficulty
        {
            easy = 5,
            medium = 4,
            hard = 3
        }

        public FormMenu()
        {
            InitializeComponent();
            Crosshair = new Crosshair();
            currentDifficulty = Difficulty.easy;

            hoverPlayer = new SoundPlayer(Properties.Resources._switch);
            clickPlayer = new SoundPlayer(Properties.Resources.click);
            
            createScores();
            setFont();
        }

        private void hoverSound(object sender, EventArgs e)
        {
            hoverPlayer.Play();
        }

        private void clickSound(object sender, EventArgs e)
        {
            clickPlayer.Play();
        }

        private void labelStartGame_MouseClick(object sender, MouseEventArgs e)
        {
            FormMap formMap = new FormMap();
            if (formMap.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                formMap.Close();
            }
        }

        private void FormMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                labelStartGame_MouseClick(null, null);
            }
        }

        private void labelOptions_MouseClick(object sender, MouseEventArgs e)
        {
            FormOptions formOptions = new FormOptions();
            if (formOptions.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (formOptions.changed[0] == true)
                {
                    Crosshair.Color = formOptions.color;
                }
                if (formOptions.changed[1] == true)
                {
                    Crosshair.Thickness = formOptions.thickness;
                }
                if (formOptions.changed[2] == true)
                {
                    Crosshair.Size = formOptions.size;
                }
                if (formOptions.changed[3] == true)
                {
                    Crosshair.Style = formOptions.style;
                }
            }
        }

        private void labelHowToPlay_MouseClick(object sender, MouseEventArgs e)
        {
            FormHowToPlay formHowToPlay = new FormHowToPlay();
            if (formHowToPlay.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                formHowToPlay.Close();
            }
        }

        private void labelHighscores_MouseClick(object sender, MouseEventArgs e)
        {
            FormHighscore formScores = new FormHighscore();
            if (formScores.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                formScores.Close();
            }
        }

        private void labelCredits_MouseClick(object sender, MouseEventArgs e)
        {
            FormCredits formCredits = new FormCredits();
            if (formCredits.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                formCredits.Close();
            }
        }

        private void labelExit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Quit game?", "Quit game", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void labelEasy_MouseClick(object sender, MouseEventArgs e)
        {
            currentDifficulty = Difficulty.easy;
            labelEasy.ForeColor = System.Drawing.Color.Chocolate;
            labelMedium.ForeColor = System.Drawing.Color.White;
            labelHard.ForeColor = System.Drawing.Color.White;
        }

        private void labelMedium_MouseClick(object sender, MouseEventArgs e)
        {
            currentDifficulty = Difficulty.medium;
            labelEasy.ForeColor = System.Drawing.Color.White;
            labelMedium.ForeColor = System.Drawing.Color.Chocolate;
            labelHard.ForeColor = System.Drawing.Color.White;
        }

        private void labelHard_MouseClick(object sender, MouseEventArgs e)
        {
            currentDifficulty = Difficulty.hard;
            labelEasy.ForeColor = System.Drawing.Color.White;
            labelMedium.ForeColor = System.Drawing.Color.White;
            labelHard.ForeColor = System.Drawing.Color.Chocolate;
        }

        public void addScore(int newScore, string newName)
        {
            StreamReader reader = File.OpenText("scores.txt");
            if (reader.EndOfStream)
            {
                reader.Close();
                StreamWriter writer = new StreamWriter("scores.txt");
                writer.WriteLine(string.Format("{0} {1}", newName, newScore));
                writer.Close();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                bool flag = false;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] split = line.Split(null);
                    if (int.Parse(split[1]) >= newScore)
                    {
                        sb.AppendLine(line);
                    }
                    else
                    {
                        sb.AppendLine(string.Format("{0} {1}", newName, newScore));
                        sb.AppendLine(line);
                        sb.Append(reader.ReadToEnd());
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    sb.AppendLine(string.Format("{0} {1}", newName, newScore));
                }
                reader.Close();
                StreamWriter writer = new StreamWriter("scores.txt");
                writer.Write(sb.ToString());
                writer.Close();
            }
        }

        public void createScores()
        {
            if (!File.Exists("scores.txt"))
            {
                File.CreateText("scores.txt");
            }
        }

        /// <summary>
        /// Method for setting the font in the Menu
        /// </summary>
        private void setFont()
        {
            labelTitle.Font = CustomFont.titleFont;
            labelStartGame.Font = CustomFont.menuFont;
            labelOptions.Font = CustomFont.menuFont;
            labelHowToPlay.Font = CustomFont.menuFont;
            labelHighscores.Font = CustomFont.menuFont;
            labelCredits.Font = CustomFont.menuFont;
            labelExit.Font = CustomFont.menuFont;

            labelDifficulty.Font = CustomFont.difficultyFont;
            labelEasy.Font = CustomFont.statusFont;
            labelEasy.ForeColor = System.Drawing.Color.Chocolate;
            labelMedium.Font = CustomFont.statusFont;
            labelMedium.ForeColor = System.Drawing.Color.White;
            labelHard.Font = CustomFont.statusFont;
            labelHard.ForeColor = System.Drawing.Color.White;
        }
    }
}
