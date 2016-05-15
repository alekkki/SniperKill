namespace Test_Sniper
{
    partial class FormCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredits));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.labelAP = new System.Windows.Forms.Label();
            this.labelAJ = new System.Windows.Forms.Label();
            this.labelNK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(140, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(183, 55);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Credits";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(12, 102);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(389, 33);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "This game was created by:";
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
            this.labelBack.TabIndex = 2;
            this.labelBack.Text = "Back";
            this.labelBack.Click += new System.EventHandler(this.clickSound);
            this.labelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseClick);
            this.labelBack.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelAP
            // 
            this.labelAP.AutoSize = true;
            this.labelAP.BackColor = System.Drawing.Color.Transparent;
            this.labelAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAP.ForeColor = System.Drawing.Color.White;
            this.labelAP.Location = new System.Drawing.Point(12, 209);
            this.labelAP.Name = "labelAP";
            this.labelAP.Size = new System.Drawing.Size(330, 33);
            this.labelAP.TabIndex = 3;
            this.labelAP.Text = "- Alek Petreski 141507\r\n";
            // 
            // labelAJ
            // 
            this.labelAJ.AutoSize = true;
            this.labelAJ.BackColor = System.Drawing.Color.Transparent;
            this.labelAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAJ.ForeColor = System.Drawing.Color.White;
            this.labelAJ.Location = new System.Drawing.Point(12, 155);
            this.labelAJ.Name = "labelAJ";
            this.labelAJ.Size = new System.Drawing.Size(418, 33);
            this.labelAJ.TabIndex = 4;
            this.labelAJ.Text = "- Andreja Jovanovski 141143";
            // 
            // labelNK
            // 
            this.labelNK.AutoSize = true;
            this.labelNK.BackColor = System.Drawing.Color.Transparent;
            this.labelNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNK.ForeColor = System.Drawing.Color.White;
            this.labelNK.Location = new System.Drawing.Point(12, 261);
            this.labelNK.Name = "labelNK";
            this.labelNK.Size = new System.Drawing.Size(355, 33);
            this.labelNK.TabIndex = 5;
            this.labelNK.Text = "- Nikola Kirovski 141025";
            // 
            // FormCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Sniper.Properties.Resources.highscores_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.labelNK);
            this.Controls.Add(this.labelAJ);
            this.Controls.Add(this.labelAP);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCredits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelAP;
        private System.Windows.Forms.Label labelAJ;
        private System.Windows.Forms.Label labelNK;
    }
}