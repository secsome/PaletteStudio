namespace PaletteStudio.GUI.Dialogs
{
    partial class Find
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
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FindColorPreview = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ckbAdd2Selections = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(67, 7);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(68, 21);
            this.nudRed.TabIndex = 1;
            this.nudRed.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(67, 34);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(68, 21);
            this.nudGreen.TabIndex = 2;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(67, 61);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(68, 21);
            this.nudBlue.TabIndex = 3;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Blue";
            // 
            // FindColorPreview
            // 
            this.FindColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FindColorPreview.Location = new System.Drawing.Point(14, 114);
            this.FindColorPreview.Name = "FindColorPreview";
            this.FindColorPreview.Size = new System.Drawing.Size(121, 28);
            this.FindColorPreview.TabIndex = 7;
            this.FindColorPreview.TabStop = false;
            this.FindColorPreview.Click += new System.EventHandler(this.FindColorPreview_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Find Nearest Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckbAdd2Selections
            // 
            this.ckbAdd2Selections.AutoSize = true;
            this.ckbAdd2Selections.Location = new System.Drawing.Point(14, 92);
            this.ckbAdd2Selections.Name = "ckbAdd2Selections";
            this.ckbAdd2Selections.Size = new System.Drawing.Size(126, 16);
            this.ckbAdd2Selections.TabIndex = 9;
            this.ckbAdd2Selections.Text = "Add to selections";
            this.ckbAdd2Selections.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 183);
            this.Controls.Add(this.ckbAdd2Selections);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindColorPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.nudRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Find";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Find";
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FindColorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox FindColorPreview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckbAdd2Selections;
    }
}