using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Gradient : Form
    {
        
        public Gradient(PalPanel src)
        {
            InitializeComponent();
            PreviewPanel.PalSource = new PalFile();
            Misc.DeepCopy(src.PalSource.Data, PreviewPanel.PalSource.Data);
            Misc.DeepCopy(src.Selections, PreviewPanel.Selections);
            InitializeStartingGroup(PreviewPanel.Selections.LastOrDefault());
            InitializeEndingGroup(PreviewPanel.Selections.LastOrDefault());
            nudStartingIdx.Value = PreviewPanel.Selections.LastOrDefault();
        }

        #region Starting Color - Gradient
        private void InitializeStartingGroup(byte idx)
        {
            IsSColorUpdating = true;
            Color tmp = Color.FromArgb(PreviewPanel.PalSource[idx]);
            nudRedS.Value = tmp.R;
            nudGreenS.Value = tmp.G;
            nudBlueS.Value = tmp.B;
            UpdateSPreview();
            IsSColorUpdating = false;
        }
        private bool IsSColorUpdating=false;
        private void UpdateSPreview()
        {
            StartingPreview.BackColor = Color.FromArgb(252, (int)nudRedS.Value, (int)nudGreenS.Value, (int)nudBlueS.Value);
        }
        private void StartingPreview_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = StartingPreview.BackColor;
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                StartingPreview.BackColor = Color.FromArgb(252, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                IsSColorUpdating = true;
                nudRedS.Value = colorDialog.Color.R;
                nudGreenS.Value = colorDialog.Color.G;
                nudBlueS.Value = colorDialog.Color.B;
                IsSColorUpdating = false;
                UpdateSPreview();
            }
        }
        private void nudS_ValueChanged(object sender, EventArgs e)
        {
            if (!IsSColorUpdating)
                UpdateSPreview();
        }
        #endregion

        #region Ending Color - Gradient
        private void InitializeEndingGroup(byte idx)
        {
            IsEColorUpdating = true;
            Color tmp = Color.FromArgb(PreviewPanel.PalSource[idx]);
            nudRedE.Value = tmp.R;
            nudGreenE.Value = tmp.G;
            nudBlueE.Value = tmp.B;
            UpdateEPreview();
            IsEColorUpdating = false;
        }
        private bool IsEColorUpdating=false;
        private void UpdateEPreview()
        {
            EndingPreview.BackColor = Color.FromArgb(252, (int)nudRedE.Value, (int)nudGreenE.Value, (int)nudBlueE.Value);
        }
        private void EndingPreview_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = EndingPreview.BackColor;
            colorDialog.FullOpen = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                EndingPreview.BackColor = Color.FromArgb(252, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                IsEColorUpdating = true;
                nudRedE.Value = colorDialog.Color.R;
                nudGreenE.Value = colorDialog.Color.G;
                nudBlueE.Value = colorDialog.Color.B;
                IsEColorUpdating = false;
                UpdateEPreview();
            }
        }
        private void nudE_ValueChanged(object sender, EventArgs e)
        {
            if (!IsEColorUpdating)
                UpdateEPreview();
        }
        #endregion

        private void ckbShowSelected_CheckedChanged(object sender, EventArgs e)
        {
            PreviewPanel.IsSelectVisible = ckbShowSelected.Checked;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (nudSteps.Value == 0) Close();

        }

        #region Public Calls - Gradients
        public List<int> PalData { get { return PreviewPanel.PalSource.Data; } }
        #endregion
    }
}
