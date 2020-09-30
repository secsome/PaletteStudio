using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using PaletteStudio.Common;
using PaletteStudio.GUI.Dialogs;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace PaletteStudio
{
    public partial class Main : Form
    {
        #region Main Form
        #region File
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource != null)
                switch(MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgInfoHintForSave"], MyMessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        SaveToolStripMenuItem_Click(null, new EventArgs());
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        return;
                }

            try
            {
                New newDialog = new New();
                if (newDialog.ShowDialog() == DialogResult.OK)
                {
                    MainPanel.Close();
                    IsSaved = false;
                    SavePath = "";
                    if (MainPanel.PalSource == null) MainPanel.PalSource = new PalFile();
                    Misc.DeepCopy(newDialog.Data, MainPanel.PalSource.Data);
                    MainPanel.Refresh();
                    MainPanel_BackColorChanged(null, new EventArgs());
                    MainPanel_SelectedIndexChanged(null, new EventArgs());
                    CurrentStatusLabel.Text = Language.DICT["StslblNewSucceed"];
                    UpdateTitle(Language.DICT["MainTitleNewName"]);
                }
                MainPanel.Refresh();
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalNew"] + ex.Message);
                CurrentStatusLabel.Text = Language.DICT["StslblNewFailed"];
            }
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource != null)
                    switch (MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgInfoHintForSave"], MyMessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Yes:
                            SaveToolStripMenuItem_Click(null, new EventArgs());
                            break;
                        case DialogResult.No:
                            break;
                        default:
                            return;
                    }
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Palette File|*.pal|All Files|*.*",
                    InitialDirectory = Application.StartupPath,
                    Title = Language.DICT["MainTitle"],
                    DefaultExt = "pal",
                    CheckPathExists = true
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (SavePath.EndsWith(".ini"))
                    {
                        //TODO
                    }
                    else
                    {
                        SavePath = openFileDialog.FileName;
                        IsSaved = true;
                        Undos.Clear();
                        Redos.Clear();
                        MainPanel.Selections.Clear();
                        MainPanel.PalSource = new PalFile(SavePath);
                        MainPanel.Refresh();
                        MainPanel_SelectedIndexChanged(null, new EventArgs());
                        MainPanel_BackColorChanged(null, new EventArgs());
                        UpdateTitle(Language.DICT["MainTitleEmptyName"]);
                        CurrentStatusLabel.Text = Language.DICT["StslblOpenSucceed"];
                    }
                    
                }
            }
            catch (Exception ex)
            {
                SavePath = "";
                IsSaved = false;
                MainPanel.Close();
                CurrentStatusLabel.Text = Language.DICT["StslblOpenFailed"];
                UpdateTitle(Language.DICT["MainTitleEmptyName"]);
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalOpen"] + ex.Message);
            }
        }
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSaved && MainPanel.PalSource != null)
                {
                    MainPanel.PalSource.Save(SavePath);
                    CurrentStatusLabel.Text = Language.DICT["StslblSaveSucceed"];
                }
                else
                {
                    SaveAsToolStripMenuItem_Click(null, new EventArgs());
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblSaveFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalSave"] + ex.Message);
            }
            
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Palette File|*.pal",
                    InitialDirectory = Application.StartupPath,
                    Title = Language.DICT["MainTitle"],
                    DefaultExt = "pal",
                    CheckPathExists = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SavePath = saveFileDialog.FileName;
                    MainPanel.PalSource.Save(SavePath);
                    IsSaved = true;
                    UpdateTitle(Language.DICT["MainTitleEmptyName"]);
                    CurrentStatusLabel.Text = Language.DICT["StslblSaveSucceed"];
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblSaveFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalSave"] + ex.Message);
            }
        }
        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MainPanel.Close();
                IsSaved = false;
                SavePath = "";
                UpdateTitle(Language.DICT["MainTitleEmptyName"]);
                Undos.Clear();
                Redos.Clear();
                CurrentStatusLabel.Text = Language.DICT["StslblCloseSucceed"];
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainText"], Language.DICT["MsgFatalClose"] + ex.Message);
                CurrentStatusLabel.Text = Language.DICT["StslblCloseFailed"];
            }
        }
        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource != null)
                switch (MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgInfoHintForSave"], MyMessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.Yes:
                        SaveToolStripMenuItem_Click(null, new EventArgs());
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        return;
                }
            try
            {
                Import import = new Import();
                if (import.ShowDialog() == DialogResult.OK)
                {
                    if (MainPanel.PalSource == null)
                    {
                        MainPanel.PalSource = new PalFile();
                        MainPanel.BackColor = Constant.Colors.PaletteBlack;
                    }
                    Misc.DeepCopy(import.Data.Data, MainPanel.PalSource.Data);
                    MainPanel.Refresh();
                    MainPanel_BackColorChanged(null, new EventArgs());
                    MainPanel_SelectedIndexChanged(null, new EventArgs());
                    CurrentStatusLabel.Text = Language.DICT["StslblImportSucceed"];
                }
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalImport"] + ex.Message);
                CurrentStatusLabel.Text = Language.DICT["StslblImportFailed"];
            }
        }
        #endregion
        #region Edit
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Undos.Count > 0)
                {
                    MakeRedo();
                    Misc.DeepCopy(Undos.Last(), MainPanel.PalSource.Data);
                    Undos.RemoveAt(Undos.Count - 1);
                    MainPanel.Refresh();
                    CurrentStatusLabel.Text = Language.DICT["StslblUndoSucceed"];
                }
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalUndo"] + ex.Message);
                CurrentStatusLabel.Text = Language.DICT["StslblUndoFailed"];
            }
        }
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Redos.Count > 0)
                {
                    MakeUndo();
                    Misc.DeepCopy(Redos.Last(), MainPanel.PalSource.Data);
                    Redos.RemoveAt(Redos.Count - 1);
                    MainPanel.Refresh();
                    CurrentStatusLabel.Text = Language.DICT["StslblRedoSucceed"];
                }
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalRedo"] + ex.Message);
                CurrentStatusLabel.Text = Language.DICT["StslblRedoFailed"];
            }
        }
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource != null)
            {
                MainPanel.Selections.Clear();
                for (int i = 0; i < 256; i++) MainPanel.Selections.Add((byte)i);
                MainPanel.Refresh();
            }
        }
        #endregion
        #region Tools
        private void GradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                Gradient gradient = new Gradient(MainPanel);
                if (gradient.ShowDialog() == DialogResult.OK)
                {
                    MakeUndo();
                    Misc.DeepCopy(MainPanel.PalSource.Data, gradient.PalData);
                    MainPanel.Refresh();
                    CurrentStatusLabel.Text = Language.DICT["StslblGradientSucceed"];
                }
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalGradient"] + ex.Message);
                CurrentStatusLabel.Text = Language.DICT["StslblGradientFailed"];
            }
        }
        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource == null || GlobalVar.IsFindOpening) return;
            try
            {
                if (GlobalVar.FindWindow == null) GlobalVar.FindWindow = new Find(MainPanel);
                else GlobalVar.FindWindow.srcPanel = MainPanel;
                GlobalVar.FindWindow.Show();
                GlobalVar.IsFindOpening = true;
            }
            catch
            {
                GlobalVar.IsFindOpening = false;
            }
        }
        private void MainmenuExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "All Files|*.*",
                    InitialDirectory = Application.StartupPath,
                    Title = Language.DICT["MainTitle"],
                    DefaultExt = "ini",
                    CheckPathExists = true,
                    AddExtension = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainPanel.PalSource.Export(saveFileDialog.FileName);
                    CurrentStatusLabel.Text = Language.DICT["StslblExportSucceed"];
                }
            }
            catch (Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblExportFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalExport"] + ex.Message);
            }
        }
        private void MainmenuMergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                Merge merge = new Merge(MainPanel.PalSource);
                if (merge.ShowDialog() == DialogResult.OK)
                {
                    Misc.DeepCopy(merge.PreviewPanel.PalSource.Data, MainPanel.PalSource.Data);
                    MainPanel.Refresh();
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblMergeFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalMerge"] + ex.Message);
            }
        }
        #endregion
        #region Others
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
        private void SettingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            if (settings.ShowDialog() == DialogResult.OK)
            {
                if (GlobalVar.NewLanguage == GlobalVar.Language) return;
                switch (MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgInfoNeedsRestart"], MyMessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        GlobalVar.exitMessageBox = false;
                        Application.ExitThread();
                        Application.Restart();
                        GlobalVar.exitMessageBox = true;
                        break;
                    case DialogResult.No:
                    default:
                        break; 
                }
            }
        }
        #endregion
        #endregion

        #region Main Panel
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                MakeUndo();
                string format = "";
                format += MainPanel.Selections.Count.ToString();
                foreach (byte v in MainPanel.Selections) format += "," + v + "," + MainPanel.PalSource[v];
                Clipboard.SetData(DataFormats.Text, format);
                foreach (byte v in MainPanel.Selections) MainPanel.PalSource[v] = MainPanel.BackColor;
                MainPanel.Refresh();
                CurrentStatusLabel.Text = Language.DICT["StslblCutSucceed"].Replace("%COUNT", MainPanel.Selections.Count.ToString());
            }
            catch (Exception ex)
            {
                UndoToolStripMenuItem_Click(null, new EventArgs());
                CurrentStatusLabel.Text = Language.DICT["StslblCutFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalCut"] + ex.Message);
            }
        }
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(MainPanel.Selections.Count);
                //string format = "";
                //format += MainPanel.Selections.Count.ToString();
                foreach (byte v in MainPanel.Selections)
                    //format += "," + v + "," + MainPanel.PalSource[v];
                    sb.AppendFormat(",{0},{1}", v, MainPanel.PalSource[v]);
                Clipboard.SetData(DataFormats.Text, sb.ToString());
                CurrentStatusLabel.Text = Language.DICT["StslblCopySucceed"].Replace("%COUNT", MainPanel.Selections.Count.ToString());
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblCopyFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalCopy"] + ex.Message);
            }
            
        }
        private bool isClipboardException = true;
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                isClipboardException = true;
                if (MainPanel.PalSource == null) return;
                if (!Clipboard.ContainsData(DataFormats.StringFormat)) return;
                MakeUndo();
                string data = Clipboard.GetText(TextDataFormat.Text);
                List<Tuple<byte, int>> Colors = new List<Tuple<byte, int>>();
                isClipboardException = false;
                string[] splitedData = data.Split(',');
                int count = int.Parse(splitedData[0]);
                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                        Colors.Add(new Tuple<byte, int>(byte.Parse(splitedData[i * 2 + 1]), int.Parse(splitedData[i * 2 + 2])));
                    Colors.Sort((a, b) => a.Item1.CompareTo(b.Item1));
                    Paste paste = new Paste(MainPanel.PalSource, Colors, MainPanel.Selections.LastOrDefault());
                    if (paste.ShowDialog() == DialogResult.OK)
                    {
                        Misc.DeepCopy(paste.DataReturn, MainPanel.PalSource.Data);
                        Refresh();
                        CurrentStatusLabel.Text = Language.DICT["StslblPasteSucceed"].Replace("%COUNT", count.ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblPasteFailed"];
                if (!isClipboardException) UndoToolStripMenuItem_Click(null, new EventArgs());
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT[isClipboardException ? "MsgFatalPasteClipboard" : "MsgFatalPaste"] + ex.Message);
            }
        }
        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                MakeUndo();
                Sort sort = new Sort(MainPanel.PalSource, MainPanel.Selections);
                if (sort.ShowDialog() == DialogResult.OK)
                {
                    MainPanel.Refresh();
                    CurrentStatusLabel.Text = Language.DICT["StslblSortSucceed"];
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = Language.DICT["StslblSortFailed"];
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalSort"] + ex.Message);
            }
        }
        #endregion
    }
}
