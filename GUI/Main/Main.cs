using PaletteStudio.Common;
using PaletteStudio.FileSystem;
using PaletteStudio.GUI.Dialogs;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaletteStudio
{
    public partial class Main : Form
    {
        private bool IsSaved = false;
        private string SavePath = "";

        public Main()
        {
            InitializeComponent();
            Misc.SetLanguage(this);
        }

        #region Undo & Redo
        private readonly List<List<int>> Undos = new List<List<int>>();
        private readonly List<List<int>> Redos = new List<List<int>>();

        private void MakeUndo()
        {
            Undos.Add(new List<int>());
            Utils.Misc.DeepCopy(MainPanel.PalSource.Data, Undos.Last());
            GC.Collect();
        }
        private void MakeRedo()
        {
            Redos.Add(new List<int>());
            Utils.Misc.DeepCopy(MainPanel.PalSource.Data, Redos.Last());
            GC.Collect();
        }
        #endregion

        #region MainPanel
        private void MainPanel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color currentColor = Color.FromArgb(MainPanel.PalSource[MainPanel.Selections.LastOrDefault()]);
            isColorUpdating = true;
            nudRed.Value = currentColor.R;
            nudBlue.Value = currentColor.B;
            nudGreen.Value = currentColor.G;
            isColorUpdating = false;
            UpdatePreview();
            label4.Text = Language.DICT["MainlblCurrentIndex"] + MainPanel.Selections.LastOrDefault();
        }
        private void MainPanel_BackColorChanged(object sender, EventArgs e)
        {
            MakeUndo();
            BackColorPreview.BackColor = Color.FromArgb(MainPanel.BackColor);
        }
        private void MainPanel_PalSourceChanging(object sender, EventArgs e)
        {
            MakeUndo();
        }
        private void MainPanel_PalSourceChanged(object sender, EventArgs e)
        {
            BackColorPreview.BackColor = Color.FromArgb(MainPanel.BackColor);
            Refresh();
        }
        #endregion

        #region GUI Updates
        private void UpdatePreview()
        {
            ColorPreview.BackColor = Color.FromArgb(252, (int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
        }

        private bool isColorUpdating = false;
        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            if (!isColorUpdating)
                UpdatePreview();
        }
        private void ColorPreview_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                Color = ColorPreview.BackColor,
                FullOpen = true
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                MakeUndo();
                ColorPreview.BackColor = Color.FromArgb(252, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                isColorUpdating = true;
                nudRed.Value = colorDialog.Color.R;
                nudGreen.Value = colorDialog.Color.G;
                nudBlue.Value = colorDialog.Color.B;
                isColorUpdating = false;
                UpdatePreview();
            }
        }
        private void BackColorPreview_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog
            {
                Color = ColorPreview.BackColor,
                FullOpen = true
            };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColorPreview.BackColor = Color.FromArgb(252, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
                MainPanel.BackColor = BackColorPreview.BackColor.ToArgb();
            }

        }
        #endregion

        private void BtnApply_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource == null) return;
            MakeUndo();
            Color newColor = Color.FromArgb(252, (int)nudRed.Value, (int)nudGreen.Value, (int)nudBlue.Value);
            MainPanel.PalSource[MainPanel.Selections.LastOrDefault()] = newColor.ToArgb();
            MainPanel.Refresh();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(GlobalVar.NewLanguage != null)
            {
                if (GlobalVar.Language != GlobalVar.NewLanguage)
                {
                    GlobalVar.INI["Settings"].GetPair("CurrentLanguage").Value = GlobalVar.NewLanguage.Name;
                    GlobalVar.INI.SaveIni();
                }
            }
            if (!GlobalVar.exitMessageBox) return;
            switch(MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgInfoOnClosing"], MyMessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }


        #region Main Panel Drop Events - Main
        private void MainPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (MainPanel.AllowDropOpen)
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    string path = files.Last();
                    try
                    {
                        PalFile palFile = new PalFile(path);
                        if (MainPanel.PalSource != null)
                            switch (MyMessageBox.Show(Language.DICT["MainTitle"],Language.DICT["MsgInfoHintForSave"], MyMessageBoxButtons.YesNoCancel))
                            {
                                case DialogResult.Yes:
                                    SaveToolStripMenuItem_Click(null, new EventArgs());
                                    break;
                                case DialogResult.No:
                                    break;
                                default:
                                    return;
                            }
                        SavePath = path;
                        IsSaved = true;
                        Undos.Clear();
                        Redos.Clear();
                        MainPanel.Selections.Clear();
                        MainPanel.PalSource = palFile;
                        MainPanel.Refresh();
                        MainPanel_SelectedIndexChanged(null, new EventArgs());
                        MainPanel_BackColorChanged(null, new EventArgs());
                        CurrentStatusLabel.Text = Language.DICT["StslblOpenSucceed"];
                    }
                    catch(Exception ex)
                    {
                        SavePath = "";
                        IsSaved = false;
                        MainPanel.Close();
                        CurrentStatusLabel.Text = Language.DICT["StslblOpenFailed"];
                        MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalOpen"] + ex.Message);
                    }
                }
            }
        }
        private void MainPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void MainPanel_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        #endregion
    }
}
