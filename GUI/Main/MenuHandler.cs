using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using PaletteStudio.GUI;
using PaletteStudio.GUI.Dialogs;

namespace PaletteStudio
{
    public partial class Main : Form
    {
        #region Main Form
        #region File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Palette File|*.pal|All Files|*.*";
                openFileDialog.InitialDirectory = Application.StartupPath;
                openFileDialog.Title = "Open a palette file,,,";
                openFileDialog.DefaultExt = "pal";
                openFileDialog.CheckPathExists = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SavePath = openFileDialog.FileName;
                    IsSaved = true;
                    MainPanel.PalSource = new PalFile(SavePath);
                    MainPanel.Refresh();
                    MainPanel_SelectedIndexChanged(null, new EventArgs());
                    CurrentStatusLabel.Text = "Palette opened";
                }
            }
            catch (Exception ex)
            {
                SavePath = "";
                IsSaved = false;
                MainPanel.Close();
                CurrentStatusLabel.Text = "Failed to read the palette file";
                MessageBox.Show("Failed to read the palette file, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsSaved && MainPanel.PalSource != null)
                {
                    MainPanel.PalSource.Save(SavePath);
                    CurrentStatusLabel.Text = "Successfully saved the palette";
                }
                else
                {
                    saveAsToolStripMenuItem_Click(null, new EventArgs());
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = "Failed to save the palette file";
                MessageBox.Show("Failed to save the palette file, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Palette File|*.pal";
                saveFileDialog.InitialDirectory = Application.StartupPath;
                saveFileDialog.Title = "Save a palette file...";
                saveFileDialog.DefaultExt = "pal";
                saveFileDialog.CheckPathExists = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SavePath = saveFileDialog.FileName;
                    MainPanel.PalSource.Save(SavePath);
                    IsSaved = true;
                    CurrentStatusLabel.Text = "Successfully saved the palette";
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = "Failed to save the palette file";
                MessageBox.Show("Failed to save the palette file, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Close();
            IsSaved = false;
            SavePath = "";
            CurrentStatusLabel.Text = "Palette file closed";
        }
        #endregion
        #region Edit
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Undos.Count > 0)
            {
                MakeRedo();
                for (int i = 0; i < 256; i++)
                    MainPanel.PalSource[(byte)i] = Undos.Last()[(byte)i];
                Undos.RemoveAt(Undos.Count - 1);
                MainPanel.Refresh();
                CurrentStatusLabel.Text = "Undo";
            }  
        }
        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Redos.Count > 0)
            {
                MakeUndo();
                for (int i = 0; i < 256; i++)
                    MainPanel.PalSource[(byte)i] = Redos.Last()[(byte)i];
                Redos.RemoveAt(Redos.Count - 1);
                MainPanel.Refresh();
                CurrentStatusLabel.Text = "Redo";
            }
        }
        #endregion
        #region Others
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.Dialogs.About about = new GUI.Dialogs.About();
            about.ShowDialog();
        }
        #endregion
        #endregion

        #region Main Panel
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                string format = "";
                format += MainPanel.Selections.Count.ToString();
                foreach (byte v in MainPanel.Selections) format += "," + v + "," + Misc.ColorToString(MainPanel.PalSource[v]);
                Clipboard.SetData(DataFormats.Text, format);
                CurrentStatusLabel.Text = "Successfully copied " + MainPanel.Selections.Count + " items to clipboard as string";
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = "Failed to copy";
                MessageBox.Show("Failed to copy, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                if (!Clipboard.ContainsData(DataFormats.StringFormat)) return;
                MakeUndo();
                int[] backupPalData = new int[256];
                for (int i = 0; i < 256; i++) backupPalData[(byte)i] = MainPanel.PalSource[(byte)i];
                string data = Clipboard.GetText(TextDataFormat.Text);
                List<ValueTuple<byte, byte, byte, byte>> Colors = new List<(byte, byte, byte, byte)>();
                try
                {
                    string[] splitedData = data.Split(',');
                    int count = int.Parse(splitedData[0]);
                    if (count > 0)
                    {
                        for (int i = 0; i < count; i++)
                            Colors.Add((byte.Parse(splitedData[i * 4 + 1]), byte.Parse(splitedData[i * 4 + 2]), byte.Parse(splitedData[i * 4 + 3]), byte.Parse(splitedData[i * 4 + 4])));
                        Colors.Sort((a, b) => a.Item1.CompareTo(b.Item1));
                        Paste paste = new Paste(MainPanel.PalSource, Colors, MainPanel.Selections.LastOrDefault());
                        paste.ShowDialog();
                        Refresh();
                        CurrentStatusLabel.Text = "Successfully paste " + count + " items";
                    }
                }
                catch (Exception ex)
                {
                    // Recover it
                    for (int i = 0; i < 256; i++) MainPanel.PalSource[(byte)i] = backupPalData[(byte)i];
                    CurrentStatusLabel.Text = "Failed to paste items";
                    MessageBox.Show("Fatal Error Occored, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = "Failed to paste items";
                MessageBox.Show("Fatal Error Occored while reading the clipboard, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainPanel.PalSource == null) return;
                MakeUndo();
                Sort sort = new Sort(MainPanel.PalSource, MainPanel.Selections);
                if (sort.ShowDialog() == DialogResult.OK)
                {
                    MainPanel.Refresh();
                    CurrentStatusLabel.Text = "Successfully sorted the palette";
                }
            }
            catch(Exception ex)
            {
                CurrentStatusLabel.Text = "Failed to sort";
                MessageBox.Show("Failed to sort, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
