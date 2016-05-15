using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Sniper
{
    public partial class FormDialog : Form
    {
        public string name { get; set; }
        public FormMap formMap;
        ErrorProvider errorProvider = new ErrorProvider();

        public FormDialog()
        {
            InitializeComponent();
            formMap = (FormMap)ActiveForm;
            if (formMap.win)
            {
                labelCong.Show();
                labelGameOver.Hide();
            }
            else
            {
                labelCong.Hide();
                labelGameOver.Show();
            }
            setFont();
            Cursor.Show();
        }

        private void FormDialog_Load(object sender, EventArgs e)
        {
            labelScore.Text = formMap.player.getScore();
        }

        private void labelSubmit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            name = textBoxName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxName, "Insert name!");
            }
            else if (textBoxName.Text.Trim().Length > 10)
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxName, "Maximum 10 characters!");
            }
            else if(textBoxName.Text.Contains(" "))
            {
                e.Cancel = true;
                errorProvider.SetError(textBoxName, "One word only!");
            }
            else
            {
                errorProvider.SetError(textBoxName, null);
            }
        }

        /// <summary>
        /// Method for setting the font in the Dialog
        /// </summary>
        public void setFont()
        {
            labelCong.Font = CustomFont.smallFont;
            labelGameOver.Font = CustomFont.smallFont;
            labelScores.Font = CustomFont.styleFont;
            labelScore.Font = CustomFont.styleFont;
            labelName.Font = CustomFont.styleFont;
            textBoxName.Font = CustomFont.styleFont;
            labelSubmit.Font = CustomFont.styleFont;
        }
    }
}
