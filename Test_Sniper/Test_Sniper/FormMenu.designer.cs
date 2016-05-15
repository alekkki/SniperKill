namespace Test_Sniper
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelEasy = new System.Windows.Forms.Label();
            this.labelMedium = new System.Windows.Forms.Label();
            this.labelHard = new System.Windows.Forms.Label();
            this.labelStartGame = new System.Windows.Forms.Label();
            this.labelOptions = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.labelHighscores = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelHowToPlay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitle.Location = new System.Drawing.Point(374, 40);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(393, 91);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Sniper Kill";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDifficulty.Location = new System.Drawing.Point(12, 469);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(135, 33);
            this.labelDifficulty.TabIndex = 1;
            this.labelDifficulty.Text = "Difficulty:";
            // 
            // labelEasy
            // 
            this.labelEasy.AutoSize = true;
            this.labelEasy.BackColor = System.Drawing.Color.Transparent;
            this.labelEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEasy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEasy.Location = new System.Drawing.Point(198, 471);
            this.labelEasy.Name = "labelEasy";
            this.labelEasy.Size = new System.Drawing.Size(69, 29);
            this.labelEasy.TabIndex = 2;
            this.labelEasy.Text = "Easy";
            this.labelEasy.Click += new System.EventHandler(this.clickSound);
            this.labelEasy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelEasy_MouseClick);
            this.labelEasy.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelMedium
            // 
            this.labelMedium.AutoSize = true;
            this.labelMedium.BackColor = System.Drawing.Color.Transparent;
            this.labelMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMedium.Location = new System.Drawing.Point(282, 471);
            this.labelMedium.Name = "labelMedium";
            this.labelMedium.Size = new System.Drawing.Size(106, 29);
            this.labelMedium.TabIndex = 3;
            this.labelMedium.Text = "Medium";
            this.labelMedium.Click += new System.EventHandler(this.clickSound);
            this.labelMedium.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelMedium_MouseClick);
            this.labelMedium.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelHard
            // 
            this.labelHard.AutoSize = true;
            this.labelHard.BackColor = System.Drawing.Color.Transparent;
            this.labelHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHard.Location = new System.Drawing.Point(394, 471);
            this.labelHard.Name = "labelHard";
            this.labelHard.Size = new System.Drawing.Size(69, 29);
            this.labelHard.TabIndex = 4;
            this.labelHard.Text = "Hard";
            this.labelHard.Click += new System.EventHandler(this.clickSound);
            this.labelHard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelHard_MouseClick);
            this.labelHard.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelStartGame
            // 
            this.labelStartGame.AutoSize = true;
            this.labelStartGame.BackColor = System.Drawing.Color.Transparent;
            this.labelStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStartGame.Location = new System.Drawing.Point(662, 168);
            this.labelStartGame.Name = "labelStartGame";
            this.labelStartGame.Size = new System.Drawing.Size(207, 42);
            this.labelStartGame.TabIndex = 5;
            this.labelStartGame.Text = "Start Game";
            this.labelStartGame.Click += new System.EventHandler(this.clickSound);
            this.labelStartGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelStartGame_MouseClick);
            this.labelStartGame.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.BackColor = System.Drawing.Color.Transparent;
            this.labelOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOptions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOptions.Location = new System.Drawing.Point(692, 213);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(147, 42);
            this.labelOptions.TabIndex = 6;
            this.labelOptions.Text = "Options";
            this.labelOptions.Click += new System.EventHandler(this.clickSound);
            this.labelOptions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelOptions_MouseClick);
            this.labelOptions.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.BackColor = System.Drawing.Color.Transparent;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCredits.Location = new System.Drawing.Point(697, 348);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(136, 42);
            this.labelCredits.TabIndex = 7;
            this.labelCredits.Text = "Credits";
            this.labelCredits.Click += new System.EventHandler(this.clickSound);
            this.labelCredits.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelCredits_MouseClick);
            this.labelCredits.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelHighscores
            // 
            this.labelHighscores.AutoSize = true;
            this.labelHighscores.BackColor = System.Drawing.Color.Transparent;
            this.labelHighscores.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighscores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHighscores.Location = new System.Drawing.Point(662, 303);
            this.labelHighscores.Name = "labelHighscores";
            this.labelHighscores.Size = new System.Drawing.Size(206, 42);
            this.labelHighscores.TabIndex = 8;
            this.labelHighscores.Text = "Highscores";
            this.labelHighscores.Click += new System.EventHandler(this.clickSound);
            this.labelHighscores.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelHighscores_MouseClick);
            this.labelHighscores.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelExit.Location = new System.Drawing.Point(725, 393);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(80, 42);
            this.labelExit.TabIndex = 9;
            this.labelExit.Text = "Exit";
            this.labelExit.Click += new System.EventHandler(this.clickSound);
            this.labelExit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelExit_MouseClick);
            this.labelExit.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelHowToPlay
            // 
            this.labelHowToPlay.AutoSize = true;
            this.labelHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHowToPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHowToPlay.Location = new System.Drawing.Point(659, 258);
            this.labelHowToPlay.Name = "labelHowToPlay";
            this.labelHowToPlay.Size = new System.Drawing.Size(213, 42);
            this.labelHowToPlay.TabIndex = 10;
            this.labelHowToPlay.Text = "How to play";
            this.labelHowToPlay.Click += new System.EventHandler(this.clickSound);
            this.labelHowToPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelHowToPlay_MouseClick);
            this.labelHowToPlay.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Sniper.Properties.Resources.menu_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 511);
            this.Controls.Add(this.labelHowToPlay);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelHighscores);
            this.Controls.Add(this.labelCredits);
            this.Controls.Add(this.labelOptions);
            this.Controls.Add(this.labelStartGame);
            this.Controls.Add(this.labelHard);
            this.Controls.Add(this.labelMedium);
            this.Controls.Add(this.labelEasy);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.labelTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniper Kill";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMenu_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelEasy;
        private System.Windows.Forms.Label labelMedium;
        private System.Windows.Forms.Label labelHard;
        private System.Windows.Forms.Label labelStartGame;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.Label labelHighscores;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelHowToPlay;
    }
}