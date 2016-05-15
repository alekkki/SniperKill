namespace Test_Sniper
{
    partial class FormHowToPlay
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
            this.labelText = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.labelShow = new System.Windows.Forms.Label();
            this.labelHide = new System.Windows.Forms.Label();
            this.pictureBoxLeftClick = new System.Windows.Forms.PictureBox();
            this.labelLeftClick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftClick)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(103, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(286, 55);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "How to play";
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
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.BackColor = System.Drawing.Color.Transparent;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.White;
            this.labelText.Location = new System.Drawing.Point(12, 64);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(479, 210);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "The aim of this game is to \r\neliminate certain number \r\nof enemies depending\r\non " +
    "the difficulty.\r\nControls:";
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxShow.Location = new System.Drawing.Point(19, 281);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShow.TabIndex = 6;
            this.pictureBoxShow.TabStop = false;
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHide.Location = new System.Drawing.Point(19, 349);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(52, 50);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHide.TabIndex = 7;
            this.pictureBoxHide.TabStop = false;
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.BackColor = System.Drawing.Color.Transparent;
            this.labelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.ForeColor = System.Drawing.Color.White;
            this.labelShow.Location = new System.Drawing.Point(77, 309);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(183, 29);
            this.labelShow.TabIndex = 8;
            this.labelShow.Text = "Show Crosshair";
            // 
            // labelHide
            // 
            this.labelHide.AutoSize = true;
            this.labelHide.BackColor = System.Drawing.Color.Transparent;
            this.labelHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHide.ForeColor = System.Drawing.Color.White;
            this.labelHide.Location = new System.Drawing.Point(77, 371);
            this.labelHide.Name = "labelHide";
            this.labelHide.Size = new System.Drawing.Size(173, 29);
            this.labelHide.TabIndex = 9;
            this.labelHide.Text = "Hide Crosshair";
            // 
            // pictureBoxLeftClick
            // 
            this.pictureBoxLeftClick.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLeftClick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLeftClick.Location = new System.Drawing.Point(19, 208);
            this.pictureBoxLeftClick.Name = "pictureBoxLeftClick";
            this.pictureBoxLeftClick.Size = new System.Drawing.Size(52, 55);
            this.pictureBoxLeftClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftClick.TabIndex = 10;
            this.pictureBoxLeftClick.TabStop = false;
            // 
            // labelLeftClick
            // 
            this.labelLeftClick.AutoSize = true;
            this.labelLeftClick.BackColor = System.Drawing.Color.Transparent;
            this.labelLeftClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeftClick.ForeColor = System.Drawing.Color.White;
            this.labelLeftClick.Location = new System.Drawing.Point(77, 234);
            this.labelLeftClick.Name = "labelLeftClick";
            this.labelLeftClick.Size = new System.Drawing.Size(56, 29);
            this.labelLeftClick.TabIndex = 11;
            this.labelLeftClick.Text = "Fire";
            // 
            // FormHowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Sniper.Properties.Resources.highscores_wallpaper;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.labelLeftClick);
            this.Controls.Add(this.pictureBoxLeftClick);
            this.Controls.Add(this.labelHide);
            this.Controls.Add(this.labelShow);
            this.Controls.Add(this.pictureBoxHide);
            this.Controls.Add(this.pictureBoxShow);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "How to play";
            this.Load += new System.EventHandler(this.FormHowToPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.PictureBox pictureBoxHide;
        private System.Windows.Forms.Label labelShow;
        private System.Windows.Forms.Label labelHide;
        private System.Windows.Forms.PictureBox pictureBoxLeftClick;
        private System.Windows.Forms.Label labelLeftClick;
    }
}