using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Gradient : Form
    {
        private List<int> SourceColorList;

        public Gradient(PalPanel src)
        {
            InitializeComponent();
            Misc.SetLanguage(this);
            PreviewPanel.PalSource = new PalFile();
            SourceColorList = src.PalSource.Data;
            Misc.DeepCopy(SourceColorList, PreviewPanel.PalSource.Data);
            Misc.DeepCopy(src.Selections, PreviewPanel.Selections);
            InitializeStartingGroup(PreviewPanel.Selections.LastOrDefault());
            InitializeEndingGroup(PreviewPanel.Selections.LastOrDefault());
            nudStartingIdx.Value = PreviewPanel.Selections.LastOrDefault();
        }

        #region Private Methods - Gradient
        private List<byte> SortByteList(byte element,List<byte> sortList)
        {
            List<byte> mid = new List<byte>();
            List<byte> ret = new List<byte>();
            Misc.DeepCopy(sortList, mid);
            mid.Sort();
            int idx = mid.IndexOf(element);
            if (idx == -1) return null;
            ret.AddRange(mid.GetRange(idx, mid.Count - idx));
            ret.AddRange(mid.GetRange(0, idx));
            return ret;
        }

        private void UpdatePreviewPanel()
        {
            Misc.DeepCopy(SourceColorList, PreviewPanel.PalSource.Data);
            int startingIdx = (int)nudStartingIdx.Value;
            List<byte> WorkingList = SortByteList((byte)startingIdx, PreviewPanel.Selections);
            if (WorkingList == null)
            {
                PreviewPanel.Refresh();
                return;
            }
            int steps = (int)nudSteps.Value;
            Color startingColor = StartingPreview.BackColor;
            Color endingColor = EndingPreview.BackColor;
            decimal deltaR = (decimal)(endingColor.R - startingColor.R) / steps;
            decimal deltaG = (decimal)(endingColor.G - startingColor.G) / steps;
            decimal deltaB = (decimal)(endingColor.B - startingColor.B) / steps;
            int i = 0;
            decimal LastR = startingColor.R, LastG = startingColor.G, LastB = startingColor.B;
            while (i < steps)
            {
                LastR += deltaR;
                LastG += deltaG;
                LastB += deltaB;
                PreviewPanel.PalSource[WorkingList[(byte)i]] = 
                    Color.FromArgb(252, Misc.GetRound(LastR), Misc.GetRound(LastG), Misc.GetRound(LastB)).ToArgb();
                ++i;
            }
            PreviewPanel.Refresh();
        }
        #endregion

        #region Event Handlers - Gradient
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
        private bool IsSColorUpdating = false;
        private void UpdateSPreview()
        {
            StartingPreview.BackColor = Color.FromArgb(252, (int)nudRedS.Value, (int)nudGreenS.Value, (int)nudBlueS.Value);
            UpdatePreviewPanel();
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
        private bool IsEColorUpdating = false;
        private void UpdateEPreview()
        {
            EndingPreview.BackColor = Color.FromArgb(252, (int)nudRedE.Value, (int)nudGreenE.Value, (int)nudBlueE.Value);
            UpdatePreviewPanel();
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

        private bool IsNudUpdating = false;
        private void ckbShowSelected_CheckedChanged(object sender, EventArgs e)
        {
            PreviewPanel.IsSelectVisible = ckbShowSelected.Checked;
            PreviewPanel.Refresh();
        }
        private void PreviewPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<byte> SortingSels = new List<byte>();
            Misc.DeepCopy(PreviewPanel.Selections, SortingSels);
            SortingSels.Sort();
            IsNudUpdating = true;
            nudStartingIdx.Value = SortingSels.FirstOrDefault();
            nudSteps.Value = SortingSels.Count;
            IsNudUpdating = false;
            UpdatePreviewPanel();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Misc.DeepCopy(PreviewPanel.PalSource.Data, SourceColorList);
            Close();
        }
        private void PreviewUpdater(object sender, EventArgs e)
        {
            if (!IsNudUpdating && (NumericUpDown)sender == nudStartingIdx)
            {
                PreviewPanel.Selections.Clear();
                PreviewPanel.Selections.Add((byte)nudStartingIdx.Value);
                nudSteps.Value = 1;
            }
            while (nudSteps.Value > PreviewPanel.Selections.Count)
            {
                byte newSel = PreviewPanel.Selections.Max() > 254 ? (byte)0 : (byte)(PreviewPanel.Selections.Max() + 1);
                while (PreviewPanel.Selections.Contains(newSel))
                    newSel += 1;
                PreviewPanel.Selections.Add(newSel);
            }
            if (nudSteps.Value < PreviewPanel.Selections.Count)
            {
                byte curIdx = (byte)nudStartingIdx.Value;
                List<byte> sortedSel = SortByteList(curIdx, PreviewPanel.Selections);
                PreviewPanel.Selections.Clear();
                Misc.DeepCopy(sortedSel.GetRange(0, (int)nudSteps.Value), PreviewPanel.Selections);
            }
            if (!IsNudUpdating)
            {
                UpdatePreviewPanel();
            }
                
        }
        #endregion

        #region Public Calls - Gradients
        public List<int> PalData { get { return PreviewPanel.PalSource.Data; } }
        #endregion

    }
}
