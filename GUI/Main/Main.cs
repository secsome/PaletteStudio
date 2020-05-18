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
        private List<List<int>> Undos = new List<List<int>>();
        private List<List<int>> Redos = new List<List<int>>();
        private bool IsSaved = false;
        private string SavePath = "";

        public Main()
        {
            InitializeComponent();
        }

        private void MakeUndo()
        {
            Undos.Add(new List<int>());
            Utils.Misc.DeepCopy(MainPanel.PalSource.Data, Undos.Last());
        }
        private void MakeRedo()
        {
            Redos.Add(new List<int>());
            Utils.Misc.DeepCopy(MainPanel.PalSource.Data, Redos.Last());
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
            MakeUndo();
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
                MakeUndo();
                ColorPreview.BackColor = colorDialog.Color;
                isColorUpdating = true;
                nudRed.Value = colorDialog.Color.R;
                nudGreen.Value= colorDialog.Color.G;
                nudBlue.Value = colorDialog.Color.B;
                isColorUpdating = false;
                UpdatePreview();
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch(MessageBox.Show(
                "Are you sure to exit the Palette Studio? Please ensure that you have saved the file.",
                "Palette Studio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                ))
            {
                case DialogResult.Yes:
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
