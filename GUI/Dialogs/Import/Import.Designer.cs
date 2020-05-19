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
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewBox
            // 
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PreviewBox.Location = new System.Drawing.Point(0, 0);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(549, 267);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PreviewBox.TabIndex = 0;
            this.PreviewBox.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPath.Location = new System.Drawing.Point(0, 267);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 12);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Path:";
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoad.Location = new System.Drawing.Point(0, 279);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(264, 24);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImport.Location = new System.Drawing.Point(270, 279);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(279, 24);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 303);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.PreviewBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Import";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnImport;
    }
}