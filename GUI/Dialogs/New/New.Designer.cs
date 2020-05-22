namespace PaletteStudio.GUI.Dialogs
{
    partial class New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvTemplates = new System.Windows.Forms.TreeView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.PreviewPanel = new PaletteStudio.GUI.PalPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(479, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "NewlblPreview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "NewlblTemplates";
            // 
            // lvTemplates
            // 
            this.lvTemplates.Location = new System.Drawing.Point(12, 26);
            this.lvTemplates.Name = "lvTemplates";
            this.lvTemplates.Size = new System.Drawing.Size(308, 277);
            this.lvTemplates.TabIndex = 4;
            this.lvTemplates.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lvTemplates_AfterSelect);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(326, 286);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "NewbtnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(451, 286);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "NewbtnCreate";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.AllowDropOpen = false;
            this.PreviewPanel.IsEditable = false;
            this.PreviewPanel.IsMultiSelect = false;
            this.PreviewPanel.IsSelectable = false;
            this.PreviewPanel.IsSelectVisible = false;
            this.PreviewPanel.Location = new System.Drawing.Point(326, 26);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.PalSource = null;
            this.PreviewPanel.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("PreviewPanel.Selections")));
            this.PreviewPanel.Size = new System.Drawing.Size(200, 254);
            this.PreviewPanel.TabIndex = 0;
            // 
            // New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 315);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lvTemplates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreviewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NewTitle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PalPanel PreviewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView lvTemplates;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreate;
    }
}