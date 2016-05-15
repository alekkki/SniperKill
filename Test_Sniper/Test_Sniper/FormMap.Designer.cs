namespace Test_Sniper
{
    partial class FormMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMap));
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.labelLifes = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelNext = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.backgroundWorkerTime = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(960, 540);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMap_Paint);
            this.pictureBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseClick);
            this.pictureBoxMap.MouseLeave += new System.EventHandler(this.pictureBoxMap_MouseLeave);
            this.pictureBoxMap.MouseHover += new System.EventHandler(this.pictureBoxMap_MouseHover);
            this.pictureBoxMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMap_MouseMove);
            // 
            // labelLifes
            // 
            this.labelLifes.AutoSize = true;
            this.labelLifes.BackColor = System.Drawing.Color.Black;
            this.labelLifes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLifes.ForeColor = System.Drawing.Color.White;
            this.labelLifes.Location = new System.Drawing.Point(12, 550);
            this.labelLifes.Name = "labelLifes";
            this.labelLifes.Size = new System.Drawing.Size(0, 16);
            this.labelLifes.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(481, 550);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 3;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(860, 550);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 4;
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.BackColor = System.Drawing.Color.Transparent;
            this.labelNext.ForeColor = System.Drawing.Color.Transparent;
            this.labelNext.Location = new System.Drawing.Point(92, 195);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(202, 13);
            this.labelNext.TabIndex = 5;
            this.labelNext.Text = "Congratulations. Press Space to continue";
            this.labelNext.MouseHover += new System.EventHandler(this.labelNext_MouseHover);
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.BackColor = System.Drawing.Color.Transparent;
            this.labelClock.ForeColor = System.Drawing.Color.Transparent;
            this.labelClock.Location = new System.Drawing.Point(445, 541);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(37, 39);
            this.labelClock.TabIndex = 6;
            this.labelClock.Text = "          \r\n          \r\n          ";
            // 
            // backgroundWorkerTime
            // 
            this.backgroundWorkerTime.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTime_DoWork);
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(959, 579);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelLifes);
            this.Controls.Add(this.pictureBoxMap);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sniper Kill";
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Label labelLifes;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Label labelClock;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTime;
    }
}