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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Palette File|*.pal|All Files|*.*";
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Title = "Open a palette file,,,";
            openFileDialog.DefaultExt = "pal";
            openFileDialog.CheckPathExists = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                MainPanel.PalSource = new PalFile(openFileDialog.FileName);
                MainPanel.Refresh();
                MainPanel_SelectedIndexChanged(null, new EventArgs());
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Palette File|*.pal";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            saveFileDialog.Title = "Save a palette file...";
            saveFileDialog.DefaultExt = "pal";
            saveFileDialog.CheckPathExists = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                MainPanel.PalSource.Save(saveFileDialog.FileName);
            }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanel.Close();
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
            if (MainPanel.PalSource == null) return;
            string format = "";
            format += MainPanel.Selections.Count.ToString();
            foreach (byte v in MainPanel.Selections) format += "," + v + "," + Misc.ColorToString(MainPanel.PalSource[v]);
            Clipboard.SetData(DataFormats.Text, format);
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource == null) return;
            if (!Clipboard.ContainsData(DataFormats.StringFormat)) return;
            string data = Clipboard.GetText(TextDataFormat.Text);
            List<ValueTuple<byte ,byte, byte, byte>> Colors = new List<(byte, byte, byte, byte)>();
            try
            {
                string[] splitedData = data.Split(',');
                int count = int.Parse(splitedData[0]);
                for(int i = 0; i < count; i++)
                    Colors.Add((byte.Parse(splitedData[i * 4 + 1]), byte.Parse(splitedData[i * 4 + 2]), byte.Parse(splitedData[i * 4 + 3]), byte.Parse(splitedData[i * 4 + 4])));
                Colors.Sort((a, b) => a.Item1.CompareTo(b.Item1));
                Paste paste = new Paste(MainPanel.PalSource, Colors);
                paste.ShowDialog();
            }
            catch(Exception ex)
            {

            }
        }
        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainPanel.PalSource == null) return;
            GUI.Dialogs.Sort sort = new GUI.Dialogs.Sort(MainPanel.PalSource, MainPanel.Selections);
            sort.ShowDialog();
            MainPanel.Refresh();
        }
        #endregion
    }
}
