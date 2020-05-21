using PaletteStudio.Utils;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Find : Form
    {
        public PalPanel srcPanel;

        public Find(PalPanel src)
        {
            InitializeComponent();
            Misc.SetLanguage(this);
            srcPanel = src;
            isColorUpdating = true;
            Color lastSelColor = Color.FromArgb(srcPanel.PalSource[srcPanel.Selections.LastOrDefault()]);
            nudRed.Value = lastSelColor.R;
            nudGreen.Value = lastSelColor.G;
            nudBlue.Value = lastSelColor.B;
            UpdatePreview();
            isColorUpdating = false;
        }

        private void UpdatePreview()
        {
            FindColorPreview.BackColor = Color.FromArgb(252, (int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private bool isColorUpdating = false;
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (!isColorUpdating)
                UpdatePreview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (srcPanel.PalSource == null) return;
            byte idx = Misc.FindBestColor(FindColorPreview.BackColor, srcPanel.PalSource);
            if (ckbAdd2Selections.Checked)
            {
                if (!srcPanel.Selections.Contains(idx)) srcPanel.Selections.Add(idx);
                else
                {
                    srcPanel.Selections.Remove(idx);
                    srcPanel.Selections.Add(idx);
                }
            }
            else
            {
                srcPanel.Selections.Clear();
                srcPanel.Selections.Add(idx);
            }
            srcPanel.Refresh();
        }

        private void FindColorPreview_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = FindColorPreview.BackColor;
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                FindColorPreview.BackColor = Color.FromArgb(252, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                isColorUpdating = true;
                nudRed.Value = colorDialog.Color.R;
                nudGreen.Value = colorDialog.Color.G;
                nudBlue.Value = colorDialog.Color.B;
                isColorUpdating = false;
                UpdatePreview();
            }
        }

        private void Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
            Common.GlobalVar.IsFindOpening = false;
        }
    }
}
