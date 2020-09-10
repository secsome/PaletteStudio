namespace PaletteStudio.GUI.Dialogs
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
            this.rdbModeMC = new System.Windows.Forms.RadioButton();
            this.rdbModeEF = new System.Windows.Forms.RadioButton();
            this.rdbModeAV = new System.Windows.Forms.RadioButton();
            this.gpbMode = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.gpbMode.SuspendLayout();
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
            this.btnLoad.Location = new System.Drawing.Point(717, 133);
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
            this.btnImport.Location = new System.Drawing.Point(717, 163);
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
            // rdbModeMC
            // 
            this.rdbModeMC.AutoSize = true;
            this.rdbModeMC.Checked = true;
            this.rdbModeMC.Location = new System.Drawing.Point(0, 20);
            this.rdbModeMC.Name = "rdbModeMC";
            this.rdbModeMC.Size = new System.Drawing.Size(113, 16);
            this.rdbModeMC.TabIndex = 7;
            this.rdbModeMC.TabStop = true;
            this.rdbModeMC.Text = "ImportrdbModeMC";
            this.rdbModeMC.UseVisualStyleBackColor = true;
            // 
            // rdbModeEF
            // 
            this.rdbModeEF.AutoSize = true;
            this.rdbModeEF.Location = new System.Drawing.Point(0, 42);
            this.rdbModeEF.Name = "rdbModeEF";
            this.rdbModeEF.Size = new System.Drawing.Size(113, 16);
            this.rdbModeEF.TabIndex = 8;
            this.rdbModeEF.Text = "ImportrdbModeEF";
            this.rdbModeEF.UseVisualStyleBackColor = true;
            // 
            // rdbModeAV
            // 
            this.rdbModeAV.AutoSize = true;
            this.rdbModeAV.Enabled = false;
            this.rdbModeAV.Location = new System.Drawing.Point(0, 64);
            this.rdbModeAV.Name = "rdbModeAV";
            this.rdbModeAV.Size = new System.Drawing.Size(113, 16);
            this.rdbModeAV.TabIndex = 9;
            this.rdbModeAV.Text = "ImportrdbModeAV";
            this.rdbModeAV.UseVisualStyleBackColor = true;
            // 
            // gpbMode
            // 
            this.gpbMode.Controls.Add(this.rdbModeMC);
            this.gpbMode.Controls.Add(this.rdbModeAV);
            this.gpbMode.Controls.Add(this.rdbModeEF);
            this.gpbMode.Location = new System.Drawing.Point(717, 193);
            this.gpbMode.Name = "gpbMode";
            this.gpbMode.Size = new System.Drawing.Size(102, 91);
            this.gpbMode.TabIndex = 10;
            this.gpbMode.TabStop = false;
            this.gpbMode.Text = "ImportgpbMode";
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 438);
            this.Controls.Add(this.gpbMode);
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
            this.gpbMode.ResumeLayout(false);
            this.gpbMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.RadioButton rdbModeMC;
        private System.Windows.Forms.RadioButton rdbModeEF;
        private System.Windows.Forms.RadioButton rdbModeAV;
        private System.Windows.Forms.GroupBox gpbMode;
    }
}