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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(0, 267);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(95, 12);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "ImportlblPrefix";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(0, 279);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(264, 24);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "ImportbtnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Location = new System.Drawing.Point(270, 279);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(279, 24);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "ImportbtnImport";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(264, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 239);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.PreviewBox);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 264);
            this.panel2.TabIndex = 5;
            // 
            // PreviewBox
            // 
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(549, 267);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PreviewBox.TabIndex = 6;
            this.PreviewBox.TabStop = false;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox PreviewBox;
    }
}