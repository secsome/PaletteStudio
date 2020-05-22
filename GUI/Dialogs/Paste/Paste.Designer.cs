namespace PaletteStudio.GUI.Dialogs
{
    partial class Paste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paste));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.rbtnOrigin = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbBack2Front = new System.Windows.Forms.CheckBox();
            this.ckbReserved = new System.Windows.Forms.CheckBox();
            this.nudStarting = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbIgnoreSpace = new System.Windows.Forms.CheckBox();
            this.rbtnToTheEnd = new System.Windows.Forms.RadioButton();
            this.rbtnJumpToStart = new System.Windows.Forms.RadioButton();
            this.btnPaste = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PreviewPanel = new PaletteStudio.GUI.PalPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarting)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCustom);
            this.groupBox1.Controls.Add(this.rbtnOrigin);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 49);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paste To";
            this.groupBox1.Visible = false;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Checked = true;
            this.rbtnCustom.Location = new System.Drawing.Point(96, 20);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(59, 16);
            this.rbtnCustom.TabIndex = 1;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            this.rbtnCustom.CheckedChanged += new System.EventHandler(this.RbtnPasteTo_CheckedChanged);
            // 
            // rbtnOrigin
            // 
            this.rbtnOrigin.AutoSize = true;
            this.rbtnOrigin.Location = new System.Drawing.Point(6, 20);
            this.rbtnOrigin.Name = "rbtnOrigin";
            this.rbtnOrigin.Size = new System.Drawing.Size(59, 16);
            this.rbtnOrigin.TabIndex = 0;
            this.rbtnOrigin.Text = "Origin";
            this.rbtnOrigin.UseVisualStyleBackColor = true;
            this.rbtnOrigin.CheckedChanged += new System.EventHandler(this.RbtnPasteTo_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbBack2Front);
            this.groupBox2.Controls.Add(this.ckbReserved);
            this.groupBox2.Controls.Add(this.nudStarting);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ckbIgnoreSpace);
            this.groupBox2.Controls.Add(this.rbtnToTheEnd);
            this.groupBox2.Controls.Add(this.rbtnJumpToStart);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 278);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PastegpbCustom";
            // 
            // ckbBack2Front
            // 
            this.ckbBack2Front.AutoSize = true;
            this.ckbBack2Front.Location = new System.Drawing.Point(6, 120);
            this.ckbBack2Front.Name = "ckbBack2Front";
            this.ckbBack2Front.Size = new System.Drawing.Size(132, 16);
            this.ckbBack2Front.TabIndex = 7;
            this.ckbBack2Front.Text = "PasteckbBack2Front";
            this.ckbBack2Front.UseVisualStyleBackColor = true;
            this.ckbBack2Front.CheckedChanged += new System.EventHandler(this.CkbBack2Front_CheckedChanged);
            // 
            // ckbReserved
            // 
            this.ckbReserved.AutoSize = true;
            this.ckbReserved.Enabled = false;
            this.ckbReserved.Location = new System.Drawing.Point(17, 98);
            this.ckbReserved.Name = "ckbReserved";
            this.ckbReserved.Size = new System.Drawing.Size(120, 16);
            this.ckbReserved.TabIndex = 6;
            this.ckbReserved.Text = "PasteckbReserved";
            this.ckbReserved.UseVisualStyleBackColor = true;
            this.ckbReserved.CheckedChanged += new System.EventHandler(this.CkbReserved_CheckedChanged);
            // 
            // nudStarting
            // 
            this.nudStarting.Location = new System.Drawing.Point(26, 250);
            this.nudStarting.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudStarting.Name = "nudStarting";
            this.nudStarting.Size = new System.Drawing.Size(120, 21);
            this.nudStarting.TabIndex = 5;
            this.nudStarting.ValueChanged += new System.EventHandler(this.NudStarting_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "PastelblStartingIndex";
            // 
            // ckbIgnoreSpace
            // 
            this.ckbIgnoreSpace.AutoSize = true;
            this.ckbIgnoreSpace.Location = new System.Drawing.Point(6, 76);
            this.ckbIgnoreSpace.Name = "ckbIgnoreSpace";
            this.ckbIgnoreSpace.Size = new System.Drawing.Size(144, 16);
            this.ckbIgnoreSpace.TabIndex = 3;
            this.ckbIgnoreSpace.Text = "PasteckbIgnoreSpaces";
            this.ckbIgnoreSpace.UseVisualStyleBackColor = true;
            this.ckbIgnoreSpace.CheckedChanged += new System.EventHandler(this.CkbIgnoreSpace_CheckedChanged);
            // 
            // rbtnToTheEnd
            // 
            this.rbtnToTheEnd.AutoSize = true;
            this.rbtnToTheEnd.Checked = true;
            this.rbtnToTheEnd.Location = new System.Drawing.Point(6, 20);
            this.rbtnToTheEnd.Name = "rbtnToTheEnd";
            this.rbtnToTheEnd.Size = new System.Drawing.Size(125, 16);
            this.rbtnToTheEnd.TabIndex = 2;
            this.rbtnToTheEnd.TabStop = true;
            this.rbtnToTheEnd.Text = "PasterdbPaste2End";
            this.rbtnToTheEnd.UseVisualStyleBackColor = true;
            this.rbtnToTheEnd.CheckedChanged += new System.EventHandler(this.RbtnCustoms_CheckedChanged);
            // 
            // rbtnJumpToStart
            // 
            this.rbtnJumpToStart.AutoSize = true;
            this.rbtnJumpToStart.Location = new System.Drawing.Point(6, 42);
            this.rbtnJumpToStart.Name = "rbtnJumpToStart";
            this.rbtnJumpToStart.Size = new System.Drawing.Size(137, 16);
            this.rbtnJumpToStart.TabIndex = 1;
            this.rbtnJumpToStart.Text = "PasterdbCycle2Start";
            this.rbtnJumpToStart.UseVisualStyleBackColor = true;
            this.rbtnJumpToStart.CheckedChanged += new System.EventHandler(this.RbtnCustoms_CheckedChanged);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(12, 296);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(166, 23);
            this.btnPaste.TabIndex = 9;
            this.btnPaste.Text = "PastebtnPaste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "PastelblPreview";
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.AllowDropOpen = false;
            this.PreviewPanel.IsEditable = false;
            this.PreviewPanel.IsMultiSelect = false;
            this.PreviewPanel.IsSelectable = true;
            this.PreviewPanel.IsSelectVisible = false;
            this.PreviewPanel.Location = new System.Drawing.Point(184, 27);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.PalSource = null;
            this.PreviewPanel.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("PreviewPanel.Selections")));
            this.PreviewPanel.Size = new System.Drawing.Size(238, 292);
            this.PreviewPanel.TabIndex = 6;
            this.PreviewPanel.SelectedIndexChanged += new PaletteStudio.GUI.PalPanel.SelectedIndexChangedHandle(this.PreviewPanel_SelectedIndexChanged);
            // 
            // Paste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PreviewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paste";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PasteTitle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStarting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PalPanel PreviewPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCustom;
        private System.Windows.Forms.RadioButton rbtnOrigin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudStarting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbIgnoreSpace;
        private System.Windows.Forms.RadioButton rbtnToTheEnd;
        private System.Windows.Forms.RadioButton rbtnJumpToStart;
        private System.Windows.Forms.CheckBox ckbReserved;
        private System.Windows.Forms.CheckBox ckbBack2Front;
    }
}