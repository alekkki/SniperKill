namespace Test_Sniper
{
    partial class FormHighscore
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.labelScores = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(98, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(275, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Highscores";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(393, 422);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(79, 31);
            this.labelBack.TabIndex = 3;
            this.labelBack.Text = "Back";
            this.labelBack.Click += new System.EventHandler(this.clickSound);
            this.labelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseClick);
            this.labelBack.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.BackColor = System.Drawing.Color.Transparent;
            this.labelNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumbers.ForeColor = System.Drawing.Color.White;
            this.labelNumbers.Location = new System.Drawing.Point(12, 63);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(65, 390);
            this.labelNumbers.TabIndex = 4;
            this.labelNumbers.Text = " 1.\r\n 2.\r\n 3.\r\n 4.\r\n 5.\r\n 6.\r\n 7.\r\n 8.\r\n 9.\r\n10.";
            this.labelNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelScores
            // 
            this.labelScores.AutoSize = true;
            this.labelScores.BackColor = System.Drawing.Color.Transparent;
            this.labelScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScores.ForeColor = System.Drawing.Color.White;
            this.labelScores.Location = new System.Drawing.Point(93, 64);
            this.labelScores.Name = "labelScores";
            this.labelScores.Size = new System.Drawing.Size(0, 39);
            this.labelScores.TabIndex = 5;
            // 
            // FormHighscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Sniper.Properties.Resources.highscores_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.labelScores);
            this.Controls.Add(this.labelNumbers);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHighscore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highscores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.Label labelScores;
    }
}