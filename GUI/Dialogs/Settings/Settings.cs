using PaletteStudio.Common;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Misc.SetLanguage(this);
            cbbLanguage.Items.AddRange(GlobalVar.INI["Language"].DataList.ToArray());
            cbbLanguage.SelectedItem = GlobalVar.INI["Language"].GetPair(GlobalVar.INI["Settings"]["CurrentLanguage"]);
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                GlobalVar.NewLanguage = (INIPair)cbbLanguage.SelectedItem;
                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalSettings"] + ex.Message);
            }
            Close();
        }
    }
}
