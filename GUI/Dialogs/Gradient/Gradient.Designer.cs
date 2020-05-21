namespace PaletteStudio.GUI.Dialogs
{
    partial class Gradient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gradient));
            this.label1 = new System.Windows.Forms.Label();
            this.ckbBack2Front = new System.Windows.Forms.CheckBox();
            this.ckbAllowCycle = new System.Windows.Forms.CheckBox();
            this.StartingPreview = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudBlueS = new System.Windows.Forms.NumericUpDown();
            this.nudGreenS = new System.Windows.Forms.NumericUpDown();
            this.nudRedS = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudBlueE = new System.Windows.Forms.NumericUpDown();
            this.nudGreenE = new System.Windows.Forms.NumericUpDown();
            this.nudRedE = new System.Windows.Forms.NumericUpDown();
            this.EndingPreview = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudStartingIdx = new System.Windows.Forms.NumericUpDown();
            this.ckbShowSelected = new System.Windows.Forms.CheckBox();
            this.PreviewPanel = new PaletteStudio.GUI.PalPanel();
            ((System.ComponentModel.ISupportInitialize)(this.StartingPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlueS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedS)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlueE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingIdx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "GradientlblPreview";
            // 
            // ckbBack2Front
            // 
            this.ckbBack2Front.AutoSize = true;
            this.ckbBack2Front.Location = new System.Drawing.Point(158, 282);
            this.ckbBack2Front.Name = "ckbBack2Front";
            this.ckbBack2Front.Size = new System.Drawing.Size(150, 16);
            this.ckbBack2Front.TabIndex = 2;
            this.ckbBack2Front.Text = "GradientckbBack2Front";
            this.ckbBack2Front.UseVisualStyleBackColor = true;
            this.ckbBack2Front.Visible = false;
            // 
            // ckbAllowCycle
            // 
            this.ckbAllowCycle.AutoSize = true;
            this.ckbAllowCycle.Location = new System.Drawing.Point(296, 282);
            this.ckbAllowCycle.Name = "ckbAllowCycle";
            this.ckbAllowCycle.Size = new System.Drawing.Size(120, 16);
            this.ckbAllowCycle.TabIndex = 3;
            this.ckbAllowCycle.Text = "GradientckbCycle";
            this.ckbAllowCycle.UseVisualStyleBackColor = true;
            this.ckbAllowCycle.Visible = false;
            // 
            // StartingPreview
            // 
            this.StartingPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StartingPreview.Location = new System.Drawing.Point(6, 20);
            this.StartingPreview.Name = "StartingPreview";
            this.StartingPreview.Size = new System.Drawing.Size(128, 32);
            this.StartingPreview.TabIndex = 4;
            this.StartingPreview.TabStop = false;
            this.StartingPreview.Click += new System.EventHandler(this.StartingPreview_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudBlueS);
            this.groupBox1.Controls.Add(this.nudGreenS);
            this.groupBox1.Controls.Add(this.nudRedS);
            this.groupBox1.Controls.Add(this.StartingPreview);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GradientgpbStarting";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "GradientlblSBlue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "GradientlblSGreen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "GradientlblSRed";
            // 
            // nudBlueS
            // 
            this.nudBlueS.Location = new System.Drawing.Point(61, 117);
            this.nudBlueS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlueS.Name = "nudBlueS";
            this.nudBlueS.Size = new System.Drawing.Size(73, 21);
            this.nudBlueS.TabIndex = 9;
            this.nudBlueS.ValueChanged += new System.EventHandler(this.nudS_ValueChanged);
            // 
            // nudGreenS
            // 
            this.nudGreenS.Location = new System.Drawing.Point(61, 90);
            this.nudGreenS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreenS.Name = "nudGreenS";
            this.nudGreenS.Size = new System.Drawing.Size(73, 21);
            this.nudGreenS.TabIndex = 8;
            this.nudGreenS.ValueChanged += new System.EventHandler(this.nudS_ValueChanged);
            // 
            // nudRedS
            // 
            this.nudRedS.Location = new System.Drawing.Point(61, 63);
            this.nudRedS.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRedS.Name = "nudRedS";
            this.nudRedS.Size = new System.Drawing.Size(73, 21);
            this.nudRedS.TabIndex = 7;
            this.nudRedS.ValueChanged += new System.EventHandler(this.nudS_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudBlueE);
            this.groupBox2.Controls.Add(this.nudGreenE);
            this.groupBox2.Controls.Add(this.nudRedE);
            this.groupBox2.Controls.Add(this.EndingPreview);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 144);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GradientgpbEnding";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "GradientlblEBlue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "GradientlblEGreen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "GradientlblERed";
            // 
            // nudBlueE
            // 
            this.nudBlueE.Location = new System.Drawing.Point(61, 117);
            this.nudBlueE.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlueE.Name = "nudBlueE";
            this.nudBlueE.Size = new System.Drawing.Size(73, 21);
            this.nudBlueE.TabIndex = 9;
            this.nudBlueE.ValueChanged += new System.EventHandler(this.nudE_ValueChanged);
            // 
            // nudGreenE
            // 
            this.nudGreenE.Location = new System.Drawing.Point(61, 90);
            this.nudGreenE.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreenE.Name = "nudGreenE";
            this.nudGreenE.Size = new System.Drawing.Size(73, 21);
            this.nudGreenE.TabIndex = 8;
            this.nudGreenE.ValueChanged += new System.EventHandler(this.nudE_ValueChanged);
            // 
            // nudRedE
            // 
            this.nudRedE.Location = new System.Drawing.Point(61, 63);
            this.nudRedE.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRedE.Name = "nudRedE";
            this.nudRedE.Size = new System.Drawing.Size(73, 21);
            this.nudRedE.TabIndex = 7;
            this.nudRedE.ValueChanged += new System.EventHandler(this.nudE_ValueChanged);
            // 
            // EndingPreview
            // 
            this.EndingPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EndingPreview.Location = new System.Drawing.Point(6, 20);
            this.EndingPreview.Name = "EndingPreview";
            this.EndingPreview.Size = new System.Drawing.Size(128, 32);
            this.EndingPreview.TabIndex = 4;
            this.EndingPreview.TabStop = false;
            this.EndingPreview.Click += new System.EventHandler(this.EndingPreview_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(12, 313);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(140, 27);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "GradientbtnConfirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "GradientlblSteps";
            // 
            // nudSteps
            // 
            this.nudSteps.Location = new System.Drawing.Point(326, 313);
            this.nudSteps.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(60, 21);
            this.nudSteps.TabIndex = 13;
            this.nudSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSteps.ValueChanged += new System.EventHandler(this.PreviewUpdater);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "GradientlblStartingIdx";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudStartingIdx
            // 
            this.nudStartingIdx.Location = new System.Drawing.Point(217, 313);
            this.nudStartingIdx.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStartingIdx.Name = "nudStartingIdx";
            this.nudStartingIdx.Size = new System.Drawing.Size(58, 21);
            this.nudStartingIdx.TabIndex = 15;
            this.nudStartingIdx.ValueChanged += new System.EventHandler(this.PreviewUpdater);
            // 
            // ckbShowSelected
            // 
            this.ckbShowSelected.AutoSize = true;
            this.ckbShowSelected.Checked = true;
            this.ckbShowSelected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbShowSelected.Location = new System.Drawing.Point(158, 5);
            this.ckbShowSelected.Name = "ckbShowSelected";
            this.ckbShowSelected.Size = new System.Drawing.Size(162, 16);
            this.ckbShowSelected.TabIndex = 17;
            this.ckbShowSelected.Text = "GradientckbShowSelected";
            this.ckbShowSelected.UseVisualStyleBackColor = true;
            this.ckbShowSelected.CheckedChanged += new System.EventHandler(this.ckbShowSelected_CheckedChanged);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.AllowDropOpen = false;
            this.PreviewPanel.IsEditable = false;
            this.PreviewPanel.IsMultiSelect = true;
            this.PreviewPanel.IsSelectable = true;
            this.PreviewPanel.IsSelectVisible = true;
            this.PreviewPanel.Location = new System.Drawing.Point(158, 24);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.PalSource = null;
            this.PreviewPanel.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("PreviewPanel.Selections")));
            this.PreviewPanel.Size = new System.Drawing.Size(228, 253);
            this.PreviewPanel.TabIndex = 1;
            this.PreviewPanel.SelectedIndexChanged += new PaletteStudio.GUI.PalPanel.SelectedIndexChangedHandle(this.PreviewPanel_SelectedIndexChanged);
            // 
            // Gradient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 346);
            this.Controls.Add(this.ckbShowSelected);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudStartingIdx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.nudSteps);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbAllowCycle);
            this.Controls.Add(this.ckbBack2Front);
            this.Controls.Add(this.PreviewPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gradient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GradientTitle";
            ((System.ComponentModel.ISupportInitialize)(this.StartingPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlueS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlueE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreenE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRedE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartingIdx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private PalPanel PreviewPanel;
        private System.Windows.Forms.CheckBox ckbBack2Front;
        private System.Windows.Forms.CheckBox ckbAllowCycle;
        private System.Windows.Forms.PictureBox StartingPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudBlueS;
        private System.Windows.Forms.NumericUpDown nudGreenS;
        private System.Windows.Forms.NumericUpDown nudRedS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudBlueE;
        private System.Windows.Forms.NumericUpDown nudGreenE;
        private System.Windows.Forms.NumericUpDown nudRedE;
        private System.Windows.Forms.PictureBox EndingPreview;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudStartingIdx;
        private System.Windows.Forms.CheckBox ckbShowSelected;
    }
}