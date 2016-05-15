namespace Test_Sniper
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.labelColor = new System.Windows.Forms.Label();
            this.colorDialogSniper = new System.Windows.Forms.ColorDialog();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelThickness = new System.Windows.Forms.Label();
            this.numericUpDownT = new System.Windows.Forms.NumericUpDown();
            this.labelStyle = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.labelCrosshair = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.labelSave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownT)).BeginInit();
            this.SuspendLayout();
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.White;
            this.labelColor.Location = new System.Drawing.Point(12, 110);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(76, 25);
            this.labelColor.TabIndex = 0;
            this.labelColor.Text = "- Color";
            this.labelColor.Click += new System.EventHandler(this.clickSound);
            this.labelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelColor_MouseClick);
            this.labelColor.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(142, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(196, 55);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Options";
            // 
            // labelThickness
            // 
            this.labelThickness.AutoSize = true;
            this.labelThickness.BackColor = System.Drawing.Color.Transparent;
            this.labelThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThickness.ForeColor = System.Drawing.Color.White;
            this.labelThickness.Location = new System.Drawing.Point(12, 145);
            this.labelThickness.Name = "labelThickness";
            this.labelThickness.Size = new System.Drawing.Size(129, 25);
            this.labelThickness.TabIndex = 2;
            this.labelThickness.Text = "- Thickness:";
            // 
            // numericUpDownT
            // 
            this.numericUpDownT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numericUpDownT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownT.ForeColor = System.Drawing.Color.White;
            this.numericUpDownT.Location = new System.Drawing.Point(18, 173);
            this.numericUpDownT.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownT.Name = "numericUpDownT";
            this.numericUpDownT.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownT.TabIndex = 3;
            this.numericUpDownT.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownT.ValueChanged += new System.EventHandler(this.numericUpDownT_ValueChanged);
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.BackColor = System.Drawing.Color.Transparent;
            this.labelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStyle.ForeColor = System.Drawing.Color.White;
            this.labelStyle.Location = new System.Drawing.Point(13, 348);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(79, 25);
            this.labelStyle.TabIndex = 4;
            this.labelStyle.Text = "- Style:";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStyle.ForeColor = System.Drawing.Color.White;
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "DashDot",
            "DashDotDot"});
            this.comboBoxStyle.Location = new System.Drawing.Point(18, 376);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(248, 33);
            this.comboBoxStyle.TabIndex = 6;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            this.comboBoxStyle.Click += new System.EventHandler(this.clickSound);
            // 
            // labelCrosshair
            // 
            this.labelCrosshair.AutoSize = true;
            this.labelCrosshair.BackColor = System.Drawing.Color.Transparent;
            this.labelCrosshair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrosshair.ForeColor = System.Drawing.Color.White;
            this.labelCrosshair.Location = new System.Drawing.Point(13, 69);
            this.labelCrosshair.Name = "labelCrosshair";
            this.labelCrosshair.Size = new System.Drawing.Size(122, 29);
            this.labelCrosshair.TabIndex = 7;
            this.labelCrosshair.Text = "Crosshair:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.BackColor = System.Drawing.Color.Transparent;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.Color.White;
            this.labelSize.Location = new System.Drawing.Point(15, 221);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(73, 25);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "- Size:";
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.BackColor = System.Drawing.Color.Transparent;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBack.ForeColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(393, 428);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(60, 25);
            this.labelBack.TabIndex = 9;
            this.labelBack.Text = "Back";
            this.labelBack.Click += new System.EventHandler(this.clickSound);
            this.labelBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelBack_MouseClick);
            this.labelBack.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(18, 249);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 28);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.Text = "200";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButton1.Click += new System.EventHandler(this.clickSound);
            this.radioButton1.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Checked = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(18, 283);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 28);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "240";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButton2.Click += new System.EventHandler(this.clickSound);
            this.radioButton2.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(18, 317);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 28);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.Text = "280";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            this.radioButton3.Click += new System.EventHandler(this.clickSound);
            this.radioButton3.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // labelSave
            // 
            this.labelSave.AutoSize = true;
            this.labelSave.BackColor = System.Drawing.Color.Transparent;
            this.labelSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSave.ForeColor = System.Drawing.Color.White;
            this.labelSave.Location = new System.Drawing.Point(295, 428);
            this.labelSave.Name = "labelSave";
            this.labelSave.Size = new System.Drawing.Size(61, 25);
            this.labelSave.TabIndex = 13;
            this.labelSave.Text = "Save";
            this.labelSave.Click += new System.EventHandler(this.clickSound);
            this.labelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelSave_MouseClick);
            this.labelSave.MouseHover += new System.EventHandler(this.hoverSound);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Test_Sniper.Properties.Resources.highscores_wallpaper;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.labelSave);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelCrosshair);
            this.Controls.Add(this.comboBoxStyle);
            this.Controls.Add(this.labelStyle);
            this.Controls.Add(this.numericUpDownT);
            this.Controls.Add(this.labelThickness);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelColor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ColorDialog colorDialogSniper;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelThickness;
        private System.Windows.Forms.NumericUpDown numericUpDownT;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label labelCrosshair;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label labelSave;
    }
}