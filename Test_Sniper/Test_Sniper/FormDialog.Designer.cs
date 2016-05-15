namespace Test_Sniper
{
    partial class FormDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDialog));
            this.labelName = new System.Windows.Forms.Label();
            this.labelScores = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelSubmit = new System.Windows.Forms.Label();
            this.labelCong = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(12, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(87, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Enter your name:";
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.BackColor = System.Drawing.Color.Transparent;
            this.labelScores.ForeColor = System.Drawing.Color.White;
            this.labelScores.Location = new System.Drawing.Point(12, 70);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(71, 13);
            this.labelScores.TabIndex = 0;
            this.labelScores.Text = "Your score is:";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(230, 70);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 2;
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubmit
            // 
            this.labelSubmit.AutoSize = true;
            this.labelSubmit.BackColor = System.Drawing.Color.Transparent;
            this.labelSubmit.ForeColor = System.Drawing.Color.White;
            this.labelSubmit.Location = new System.Drawing.Point(200, 162);
            this.labelSubmit.Name = "labelSubmit";
            this.labelSubmit.Size = new System.Drawing.Size(39, 13);
            this.labelSubmit.TabIndex = 5;
            this.labelSubmit.Text = "Submit";
            this.labelSubmit.Click += new System.EventHandler(this.labelSubmit_Click);
            // 
            // labelCong
            // 
            this.labelCong.AutoSize = true;
            this.labelCong.BackColor = System.Drawing.Color.Transparent;
            this.labelCong.ForeColor = System.Drawing.Color.White;
            this.labelCong.Location = new System.Drawing.Point(26, 21);
            this.labelCong.Name = "labelCong";
            this.labelCong.Size = new System.Drawing.Size(83, 13);
            this.labelCong.TabIndex = 6;
            this.labelCong.Text = "Congratulations!";
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.ForeColor = System.Drawing.Color.White;
            this.labelGameOver.Location = new System.Drawing.Point(81, 21);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(62, 13);
            this.labelGameOver.TabIndex = 7;
            this.labelGameOver.Text = "Game over!";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(15, 126);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(264, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Sniper.Properties.Resources.highscores_wallpaper;
            this.ClientSize = new System.Drawing.Size(310, 201);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelCong);
            this.Controls.Add(this.labelSubmit);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player info";
            this.Load += new System.EventHandler(this.FormDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelScores;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelSubmit;
        private System.Windows.Forms.Label labelCong;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.TextBox textBoxName;
    }
}