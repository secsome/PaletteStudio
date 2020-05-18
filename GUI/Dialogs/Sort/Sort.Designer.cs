namespace PaletteStudio.GUI.Dialogs
{
    partial class Sort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sort));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnComprehensive = new System.Windows.Forms.RadioButton();
            this.rbtnArgb = new System.Windows.Forms.RadioButton();
            this.rbtnGray = new System.Windows.Forms.RadioButton();
            this.rbtnBrightness = new System.Windows.Forms.RadioButton();
            this.rbtnSaturation = new System.Windows.Forms.RadioButton();
            this.rbtnHue = new System.Windows.Forms.RadioButton();
            this.rbtnBlue = new System.Windows.Forms.RadioButton();
            this.rbtnGreen = new System.Windows.Forms.RadioButton();
            this.rbtnRed = new System.Windows.Forms.RadioButton();
            this.rbtnIncrease = new System.Windows.Forms.RadioButton();
            this.rbtnDecrease = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnSelected = new System.Windows.Forms.RadioButton();
            this.PreviewPanel = new PaletteStudio.GUI.PalPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbVisible = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnComprehensive);
            this.groupBox1.Controls.Add(this.rbtnArgb);
            this.groupBox1.Controls.Add(this.rbtnGray);
            this.groupBox1.Controls.Add(this.rbtnBrightness);
            this.groupBox1.Controls.Add(this.rbtnSaturation);
            this.groupBox1.Controls.Add(this.rbtnHue);
            this.groupBox1.Controls.Add(this.rbtnBlue);
            this.groupBox1.Controls.Add(this.rbtnGreen);
            this.groupBox1.Controls.Add(this.rbtnRed);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preferance";
            // 
            // rbtnComprehensive
            // 
            this.rbtnComprehensive.AutoSize = true;
            this.rbtnComprehensive.Location = new System.Drawing.Point(64, 86);
            this.rbtnComprehensive.Name = "rbtnComprehensive";
            this.rbtnComprehensive.Size = new System.Drawing.Size(101, 16);
            this.rbtnComprehensive.TabIndex = 8;
            this.rbtnComprehensive.TabStop = true;
            this.rbtnComprehensive.Text = "Comprehensive";
            this.rbtnComprehensive.UseVisualStyleBackColor = true;
            this.rbtnComprehensive.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnArgb
            // 
            this.rbtnArgb.AutoSize = true;
            this.rbtnArgb.Location = new System.Drawing.Point(6, 86);
            this.rbtnArgb.Name = "rbtnArgb";
            this.rbtnArgb.Size = new System.Drawing.Size(47, 16);
            this.rbtnArgb.TabIndex = 7;
            this.rbtnArgb.TabStop = true;
            this.rbtnArgb.Text = "Argb";
            this.rbtnArgb.UseVisualStyleBackColor = true;
            this.rbtnArgb.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnGray
            // 
            this.rbtnGray.AutoSize = true;
            this.rbtnGray.Location = new System.Drawing.Point(112, 64);
            this.rbtnGray.Name = "rbtnGray";
            this.rbtnGray.Size = new System.Drawing.Size(47, 16);
            this.rbtnGray.TabIndex = 6;
            this.rbtnGray.TabStop = true;
            this.rbtnGray.Text = "Gray";
            this.rbtnGray.UseVisualStyleBackColor = true;
            this.rbtnGray.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnBrightness
            // 
            this.rbtnBrightness.AutoSize = true;
            this.rbtnBrightness.Location = new System.Drawing.Point(6, 64);
            this.rbtnBrightness.Name = "rbtnBrightness";
            this.rbtnBrightness.Size = new System.Drawing.Size(83, 16);
            this.rbtnBrightness.TabIndex = 5;
            this.rbtnBrightness.TabStop = true;
            this.rbtnBrightness.Text = "Brightness";
            this.rbtnBrightness.UseVisualStyleBackColor = true;
            this.rbtnBrightness.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnSaturation
            // 
            this.rbtnSaturation.AutoSize = true;
            this.rbtnSaturation.Location = new System.Drawing.Point(76, 42);
            this.rbtnSaturation.Name = "rbtnSaturation";
            this.rbtnSaturation.Size = new System.Drawing.Size(83, 16);
            this.rbtnSaturation.TabIndex = 4;
            this.rbtnSaturation.TabStop = true;
            this.rbtnSaturation.Text = "Saturation";
            this.rbtnSaturation.UseVisualStyleBackColor = true;
            this.rbtnSaturation.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnHue
            // 
            this.rbtnHue.AutoSize = true;
            this.rbtnHue.Location = new System.Drawing.Point(6, 42);
            this.rbtnHue.Name = "rbtnHue";
            this.rbtnHue.Size = new System.Drawing.Size(41, 16);
            this.rbtnHue.TabIndex = 3;
            this.rbtnHue.TabStop = true;
            this.rbtnHue.Text = "Hue";
            this.rbtnHue.UseVisualStyleBackColor = true;
            this.rbtnHue.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnBlue
            // 
            this.rbtnBlue.AutoSize = true;
            this.rbtnBlue.Location = new System.Drawing.Point(112, 20);
            this.rbtnBlue.Name = "rbtnBlue";
            this.rbtnBlue.Size = new System.Drawing.Size(47, 16);
            this.rbtnBlue.TabIndex = 2;
            this.rbtnBlue.TabStop = true;
            this.rbtnBlue.Text = "Blue";
            this.rbtnBlue.UseVisualStyleBackColor = true;
            this.rbtnBlue.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnGreen
            // 
            this.rbtnGreen.AutoSize = true;
            this.rbtnGreen.Location = new System.Drawing.Point(53, 20);
            this.rbtnGreen.Name = "rbtnGreen";
            this.rbtnGreen.Size = new System.Drawing.Size(53, 16);
            this.rbtnGreen.TabIndex = 1;
            this.rbtnGreen.TabStop = true;
            this.rbtnGreen.Text = "Green";
            this.rbtnGreen.UseVisualStyleBackColor = true;
            this.rbtnGreen.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnRed
            // 
            this.rbtnRed.AutoSize = true;
            this.rbtnRed.Checked = true;
            this.rbtnRed.Location = new System.Drawing.Point(6, 20);
            this.rbtnRed.Name = "rbtnRed";
            this.rbtnRed.Size = new System.Drawing.Size(41, 16);
            this.rbtnRed.TabIndex = 0;
            this.rbtnRed.TabStop = true;
            this.rbtnRed.Text = "Red";
            this.rbtnRed.UseVisualStyleBackColor = true;
            this.rbtnRed.CheckedChanged += new System.EventHandler(this.rbtnPerferances);
            // 
            // rbtnIncrease
            // 
            this.rbtnIncrease.AutoSize = true;
            this.rbtnIncrease.Checked = true;
            this.rbtnIncrease.Location = new System.Drawing.Point(6, 20);
            this.rbtnIncrease.Name = "rbtnIncrease";
            this.rbtnIncrease.Size = new System.Drawing.Size(71, 16);
            this.rbtnIncrease.TabIndex = 0;
            this.rbtnIncrease.TabStop = true;
            this.rbtnIncrease.Text = "Increase";
            this.rbtnIncrease.UseVisualStyleBackColor = true;
            this.rbtnIncrease.CheckedChanged += new System.EventHandler(this.rbtnOrder);
            // 
            // rbtnDecrease
            // 
            this.rbtnDecrease.AutoSize = true;
            this.rbtnDecrease.Location = new System.Drawing.Point(88, 20);
            this.rbtnDecrease.Name = "rbtnDecrease";
            this.rbtnDecrease.Size = new System.Drawing.Size(71, 16);
            this.rbtnDecrease.TabIndex = 1;
            this.rbtnDecrease.TabStop = true;
            this.rbtnDecrease.Text = "Decrease";
            this.rbtnDecrease.UseVisualStyleBackColor = true;
            this.rbtnDecrease.CheckedChanged += new System.EventHandler(this.rbtnOrder);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnIncrease);
            this.groupBox2.Controls.Add(this.rbtnDecrease);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 48);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnAll);
            this.groupBox3.Controls.Add(this.rbtnSelected);
            this.groupBox3.Location = new System.Drawing.Point(12, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Range";
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Location = new System.Drawing.Point(118, 20);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(41, 16);
            this.rbtnAll.TabIndex = 1;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnRange);
            // 
            // rbtnSelected
            // 
            this.rbtnSelected.AutoSize = true;
            this.rbtnSelected.Checked = true;
            this.rbtnSelected.Location = new System.Drawing.Point(6, 20);
            this.rbtnSelected.Name = "rbtnSelected";
            this.rbtnSelected.Size = new System.Drawing.Size(71, 16);
            this.rbtnSelected.TabIndex = 0;
            this.rbtnSelected.TabStop = true;
            this.rbtnSelected.Text = "Selected";
            this.rbtnSelected.UseVisualStyleBackColor = true;
            this.rbtnSelected.CheckedChanged += new System.EventHandler(this.rbtnRange);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.IsSelectable = false;
            this.PreviewPanel.IsSelectVisible = true;
            this.PreviewPanel.Location = new System.Drawing.Point(183, 24);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.PalSource = null;
            this.PreviewPanel.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("PreviewPanel.Selections")));
            this.PreviewPanel.Size = new System.Drawing.Size(251, 237);
            this.PreviewPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preview";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbVisible
            // 
            this.ckbVisible.AutoSize = true;
            this.ckbVisible.Checked = true;
            this.ckbVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbVisible.Location = new System.Drawing.Point(183, 8);
            this.ckbVisible.Name = "ckbVisible";
            this.ckbVisible.Size = new System.Drawing.Size(102, 16);
            this.ckbVisible.TabIndex = 7;
            this.ckbVisible.Text = "Show Selected";
            this.ckbVisible.UseVisualStyleBackColor = true;
            this.ckbVisible.CheckedChanged += new System.EventHandler(this.ckbVisible_CheckedChanged);
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 268);
            this.Controls.Add(this.ckbVisible);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreviewPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sort";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBlue;
        private System.Windows.Forms.RadioButton rbtnGreen;
        private System.Windows.Forms.RadioButton rbtnRed;
        private System.Windows.Forms.RadioButton rbtnIncrease;
        private System.Windows.Forms.RadioButton rbtnDecrease;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnSelected;
        private System.Windows.Forms.RadioButton rbtnBrightness;
        private System.Windows.Forms.RadioButton rbtnSaturation;
        private System.Windows.Forms.RadioButton rbtnHue;
        private System.Windows.Forms.RadioButton rbtnGray;
        private PalPanel PreviewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnComprehensive;
        private System.Windows.Forms.RadioButton rbtnArgb;
        private System.Windows.Forms.CheckBox ckbVisible;
    }
}