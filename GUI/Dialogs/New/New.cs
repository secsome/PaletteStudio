using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class New : Form
    {
        public List<int> Data = new List<int>();

        public New()
        {
            InitializeComponent();
            Misc.SetLanguage(this);
            TreeViewInitialization();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Misc.DeepCopy(PreviewPanel.PalSource.Data, Data);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lvTemplates_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (lvTemplates.SelectedNode.Tag == null) return;
            List<int> curTag = (List<int>)lvTemplates.SelectedNode.Tag;
            if (PreviewPanel.PalSource == null) PreviewPanel.PalSource = new FileSystem.PalFile();
            PreviewPanel.PalSource.Data = curTag;
            PreviewPanel.Refresh();
        }
    }
}
