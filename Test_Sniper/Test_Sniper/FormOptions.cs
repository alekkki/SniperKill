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

namespace Test_Sniper
{
    public partial class FormOptions : Form
    {
        public Color color;
        public int thickness;
        public int size;
        public string style;
        public bool[] changed;

        public SoundPlayer hoverPlayer;
        public SoundPlayer clickPlayer;

        public FormOptions()
        {
            InitializeComponent();
            color = Color.Red;
            thickness = 2;
            size = 240;
            style = "Dash";
            changed = new bool[4];
            setFont();

            hoverPlayer = new SoundPlayer(Properties.Resources._switch);
            clickPlayer = new SoundPlayer(Properties.Resources.click);
        }

        private void hoverSound(object sender, EventArgs e)
        {
            hoverPlayer.Play();
        }

        private void clickSound(object sender, EventArgs e)
        {
            clickPlayer.Play();
        }

        private void labelColor_MouseClick(object sender, MouseEventArgs e)
        {
            if(colorDialogSniper.ShowDialog() == DialogResult.OK)
            {
                color = colorDialogSniper.Color;
                changed[0] = true;
            }
        }

        private void numericUpDownT_ValueChanged(object sender, EventArgs e)
        {
            clickPlayer.Play();
            thickness = (int)numericUpDownT.Value;
            changed[1] = true;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                size = 200;
                changed[2] = true;
            }
            else if(radioButton2.Checked == true)
            {
                size = 240;
                changed[2] = true;
            }
            else if(radioButton3.Checked == true)
            {
                size = 280;
                changed[2] = true;
            }
        }

        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickPlayer.Play();
            style = comboBoxStyle.SelectedItem.ToString();
            changed[3] = true;
        }

        private void labelSave_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Save changes?", "Save changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void labelBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Method for setting the font in the Options
        /// </summary>
        private void setFont()
        {
            labelTitle.Font = CustomFont.largeFont;
            labelCrosshair.Font = CustomFont.smallFont;
            labelColor.Font = CustomFont.styleFont;
            labelThickness.Font = CustomFont.styleFont;
            numericUpDownT.Font = CustomFont.sizeFont;
            labelSize.Font = CustomFont.styleFont;
            radioButton1.Font = CustomFont.sizeFont;
            radioButton2.Font = CustomFont.sizeFont;
            radioButton3.Font = CustomFont.sizeFont;
            labelStyle.Font = CustomFont.styleFont;
            comboBoxStyle.Font = CustomFont.styleFont;
            labelSave.Font = CustomFont.smallFont;
            labelBack.Font = CustomFont.smallFont;
        }
    }
}
