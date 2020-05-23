﻿namespace PaletteStudio.GUI.Dialogs
{
    partial class Import
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
            this.lblPath = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMaxNum = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 417);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(95, 12);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "ImportlblPrefix";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(717, 153);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 24);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "ImportbtnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(717, 183);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(102, 24);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "ImportbtnImport";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PreviewBox);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(709, 414);
            this.panel2.TabIndex = 5;
            // 
            // PreviewBox
            // 
            this.PreviewBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(549, 267);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PreviewBox.TabIndex = 6;
            this.PreviewBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(717, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "ImportlblMaxNum";
            this.label1.Visible = false;
            // 
            // nudMaxNum
            // 
            this.nudMaxNum.Enabled = false;
            this.nudMaxNum.Location = new System.Drawing.Point(719, 225);
            this.nudMaxNum.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMaxNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxNum.Name = "nudMaxNum";
            this.nudMaxNum.Size = new System.Drawing.Size(100, 21);
            this.nudMaxNum.TabIndex = 7;
            this.nudMaxNum.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMaxNum.Visible = false;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 438);
            this.Controls.Add(this.nudMaxNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportTitle";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMaxNum;
    }
}