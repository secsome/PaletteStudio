namespace PaletteStudio.GUI.Dialogs
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.palPanel1 = new PaletteStudio.GUI.PalPanel();
            this.SuspendLayout();
            // 
            // palPanel1
            // 
            this.palPanel1.AllowDropOpen = false;
            this.palPanel1.BackgroundImage = global::PaletteStudio.Properties.Resources.About;
            this.palPanel1.IsEditable = false;
            this.palPanel1.IsMultiSelect = true;
            this.palPanel1.IsSelectable = true;
            this.palPanel1.IsSelectVisible = true;
            this.palPanel1.Location = new System.Drawing.Point(0, 0);
            this.palPanel1.Name = "palPanel1";
            this.palPanel1.PalSource = null;
            this.palPanel1.Selections = ((System.Collections.Generic.List<byte>)(resources.GetObject("palPanel1.Selections")));
            this.palPanel1.Size = new System.Drawing.Size(800, 600);
            this.palPanel1.TabIndex = 0;
            this.palPanel1.Click += new System.EventHandler(this.palPanel1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.palPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutTitle";
            this.Click += new System.EventHandler(this.About_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private PalPanel palPanel1;
    }
}