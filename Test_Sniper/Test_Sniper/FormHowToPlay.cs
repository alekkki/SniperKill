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

namespace Test_Sniper
{
    public partial class FormHowToPlay : Form
    {
        public SoundPlayer hoverPlayer;
        public SoundPlayer clickPlayer;

        public FormHowToPlay()
        {
            InitializeComponent();
            hoverPlayer = new SoundPlayer(Properties.Resources._switch);
            clickPlayer = new SoundPlayer(Properties.Resources.click);
        }

        private void FormHowToPlay_Load(object sender, EventArgs e)
        {
            setFont();
            pictureBoxLeftClick.Image = Properties.Resources.left_click;
            pictureBoxShow.Image = Properties.Resources.Z;
            pictureBoxHide.Image = Properties.Resources.X;
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

        /// <summary>
        /// Method for setting the font in the How to play
        /// </summary>
        public void setFont()
        {
            labelTitle.Font = CustomFont.largeFont;
            labelText.Font = CustomFont.menuFont;
            labelShow.Font = CustomFont.smallFont;
            labelHide.Font = CustomFont.smallFont;
            labelLeftClick.Font = CustomFont.smallFont;
            labelBack.Font = CustomFont.smallFont;
        }
    }
}
