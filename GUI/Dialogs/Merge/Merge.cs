using PaletteStudio.Utils;
using PaletteStudio.FileSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Merge : Form
    {
        private PalFile srcPal = new PalFile();

        public Merge(PalFile src)
        {
            InitializeComponent();
            Misc.DeepCopy(src.Data, srcPal.Data);
            PreviewPanel.PalSource = new PalFile();
            Misc.DeepCopy(src.Data, PreviewPanel.PalSource.Data);
            NudNewCount_ValueChanged(null, new EventArgs());
            Misc.SetLanguage(this);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NudNewCount_ValueChanged(object sender, EventArgs e)
        {
            if (PreviewPanel.PalSource == null)
            {
                btnApply.Enabled = false;
                return;
            }
            btnApply.Enabled = true;
            Image img = Pal2Bmp(srcPal.Data);
            Misc.GetIndexedItem(img, PreviewPanel.PalSource, (int)nudNewCount.Value);
            PreviewPanel.Refresh();
        }

        private Bitmap Pal2Bmp(List<int> src)
        {
            Bitmap bitmap = new Bitmap(256, 1);
            for(int i = 0; i < 256; i++)
                bitmap.SetPixel(i, 0, Color.FromArgb(src[i]));
            return bitmap;
        }
    }
}
