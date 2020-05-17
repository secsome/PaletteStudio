using PaletteStudio.FileSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteStudio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void UpdatePreview()
        {
            ColorPreview.BackColor= Color.FromArgb(252, (int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value); 
        }

        private void MainPanel_SelectedIndexChanged(object sender,EventArgs e)
        {
            Color currentColor = Color.FromArgb(MainPanel.PalSource[MainPanel.Selections.LastOrDefault()]);
            isColorUpdating = true;
            nudRed.Value = currentColor.R;
            nudBlue.Value = currentColor.B;
            nudGreen.Value = currentColor.G;
            isColorUpdating = false;
            UpdatePreview();
            label4.Text = "Cur Idx:" + MainPanel.Selections.LastOrDefault();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource == null) return;
            Color newColor = Color.FromArgb(252, (int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
            MainPanel.PalSource[MainPanel.Selections.LastOrDefault()] = newColor.ToArgb();
            MainPanel.Refresh();
        }

        private bool isColorUpdating = false;
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (!isColorUpdating) 
                UpdatePreview();
        }

        private void ColorPreview_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = ColorPreview.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPreview.BackColor = colorDialog.Color;
                isColorUpdating = true;
                nudRed.Value = colorDialog.Color.R;
                nudGreen.Value= colorDialog.Color.G;
                nudBlue.Value = colorDialog.Color.B;
                isColorUpdating = false;
                UpdatePreview();
            }
        }
    }
}
