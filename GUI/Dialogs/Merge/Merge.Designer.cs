namespace PaletteStudio.GUI.Dialogs
{
    partial class Merge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Merge));
            this.label1 = new System.Windows.Forms.Label();
            this.nudNewCount = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.PreviewPanel = new PaletteStudio.GUI.PalPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "MergelblNewCount";
            // 
            // nudNewCount
            // 
            this.nudNewCount.Location = new System.Drawing.Point(12, 307);
            this.nudNewCount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudNewCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNewCount.Name = "nudNewCount";
            this.nudNewCount.Size = new System.Drawing.Size(82, 21);
            this.nudNewCount.TabIndex = 2;
            this.nudNewCount.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudNewCount.ValueChanged += new System.EventHandler(this.NudNewCount_ValueChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "MergebtnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(181, 302);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "MergebtnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.AllowDropOpen = false;
            this.PreviewPanel.IsEditable = false;
            this.PreviewPanel.IsMultiSelect = false;
            this.PreviewPanel.IsSelectable = false;
            this.PreviewPanel.IsSelectVisible = false;
            this.PreviewPanel.Location = new System.Drawing.Point(12, 12);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.PalSource = null;
            this.PreviewPanel.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("PreviewPanel.Selections")));
            this.PreviewPanel.Size = new System.Drawing.Size(244, 277);
            this.PreviewPanel.TabIndex = 0;
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 332);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.nudNewCount);
            this.Controls.Add(this.PreviewPanel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Merge";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MergeTitle";
            ((System.ComponentModel.ISupportInitialize)(this.nudNewCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNewCount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        public PalPanel PreviewPanel;
    }
}