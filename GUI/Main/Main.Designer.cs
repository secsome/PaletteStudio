namespace PaletteStudio
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.ColorPreview = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BackColorPreview = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MainPanel = new PaletteStudio.GUI.PalPanel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.importToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.fileToolStripMenuItem.Text = "MainmenuFile";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.newToolStripMenuItem.Text = "MainmenuNew";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.openToolStripMenuItem.Text = "MainmenuOpen";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveToolStripMenuItem.Text = "MainmenuSave";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.saveAsToolStripMenuItem.Text = "MainmenuSaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.closeToolStripMenuItem.Text = "MainmenuClose";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(253, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.importToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.importToolStripMenuItem.Text = "MainmenuImport";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(103, 21);
            this.editToolStripMenuItem.Text = "MainmenuEdit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.undoToolStripMenuItem.Text = "MainmenuUndo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.redoToolStripMenuItem.Text = "MainmenuRedo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.selectAllToolStripMenuItem.Text = "MainmenuSelectAll";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gradientToolStripMenuItem,
            this.toolStripMenuItem3,
            this.findToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(113, 21);
            this.toolsToolStripMenuItem.Text = "MainmenuTools";
            // 
            // gradientToolStripMenuItem
            // 
            this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
            this.gradientToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.gradientToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.gradientToolStripMenuItem.Text = "MainmenuGradient";
            this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(205, 6);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.findToolStripMenuItem.Text = "MainmenuFind";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem4,
            this.settingsToolStripMenuItem1});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(114, 21);
            this.settingsToolStripMenuItem.Text = "MainmenuOther";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.aboutToolStripMenuItem.Text = "MainmenuAbout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(197, 6);
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.settingsToolStripMenuItem1.Text = "MainmenuSettings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "MainlblRed";
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(317, 100);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(50, 21);
            this.nudRed.TabIndex = 4;
            this.nudRed.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(317, 127);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(50, 21);
            this.nudGreen.TabIndex = 6;
            this.nudGreen.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "MainlblGreen";
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(317, 154);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(50, 21);
            this.nudBlue.TabIndex = 8;
            this.nudBlue.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "MainlblBlue";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(274, 181);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(93, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "MainbtnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ColorPreview
            // 
            this.ColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ColorPreview.Location = new System.Drawing.Point(272, 210);
            this.ColorPreview.Name = "ColorPreview";
            this.ColorPreview.Size = new System.Drawing.Size(95, 21);
            this.ColorPreview.TabIndex = 11;
            this.ColorPreview.TabStop = false;
            this.ColorPreview.Click += new System.EventHandler(this.ColorPreview_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.sortToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 92);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cutToolStripMenuItem.Text = "MainmenuCut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.copyToolStripMenuItem.Text = "MainmenuCopy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.pasteToolStripMenuItem.Text = "MainmenuPaste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.sortToolStripMenuItem.Text = "MainmenuSort";
            this.sortToolStripMenuItem.Click += new System.EventHandler(this.sortToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(272, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "MainlblCurrentIndex";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CurrentStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CurrentStatusLabel
            // 
            this.CurrentStatusLabel.Name = "CurrentStatusLabel";
            this.CurrentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // BackColorPreview
            // 
            this.BackColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackColorPreview.Location = new System.Drawing.Point(272, 283);
            this.BackColorPreview.Name = "BackColorPreview";
            this.BackColorPreview.Size = new System.Drawing.Size(95, 21);
            this.BackColorPreview.TabIndex = 14;
            this.BackColorPreview.TabStop = false;
            this.BackColorPreview.Click += new System.EventHandler(this.BackColorPreview_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "MainlblBackColor";
            // 
            // MainPanel
            // 
            this.MainPanel.AllowDrop = true;
            this.MainPanel.AllowDropOpen = true;
            this.MainPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.MainPanel.IsEditable = true;
            this.MainPanel.IsMultiSelect = true;
            this.MainPanel.IsSelectable = true;
            this.MainPanel.IsSelectVisible = true;
            this.MainPanel.Location = new System.Drawing.Point(0, 27);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.PalSource = null;
            this.MainPanel.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("MainPanel.Selections")));
            this.MainPanel.Size = new System.Drawing.Size(266, 398);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.SelectedIndexChanged += new PaletteStudio.GUI.PalPanel.SelectedIndexChangedHandle(this.MainPanel_SelectedIndexChanged);
            this.MainPanel.BackColorChanged += new PaletteStudio.GUI.PalPanel.BackColorChangedHandle(this.MainPanel_BackColorChanged);
            this.MainPanel.PalSourceChanging += new PaletteStudio.GUI.PalPanel.PalSourceChangingHandle(this.MainPanel_PalSourceChanging);
            this.MainPanel.PalSourceChanged += new PaletteStudio.GUI.PalPanel.PalSourceChangedHandle(this.MainPanel_PalSourceChanged);
            this.MainPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainPanel_DragDrop);
            this.MainPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainPanel_DragEnter);
            this.MainPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.MainPanel_DragOver);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BackColorPreview);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColorPreview);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.nudBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "MainTitle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPreview)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackColorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PaletteStudio.GUI.PalPanel MainPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.PictureBox ColorPreview;
        private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel CurrentStatusLabel;
        private System.Windows.Forms.PictureBox BackColorPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

