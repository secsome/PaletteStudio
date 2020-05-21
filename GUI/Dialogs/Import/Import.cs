using ImageProcessor;
using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PaletteStudio.Common;
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
            Misc.SetLanguage(this);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Image img = new Bitmap(1, 1);
            string path = "";
            bool flag = false;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = Constant.RunTime.ProgromTitle + " - " + Constant.RunTime.ProgramVersion;
                openFileDialog.Filter =
                    "All Support Image Formats|*.pcx;*.gif;*.bmp;*.png;*.jpg;*.jpeg;*.tiff" +
                    "PCX File|*.pcx|" +
                    "GIF File|*.gif|" +
                    "BMP File|*.bmp|" +
                    "PNG File|*.png|" +
                    "JPG File|*.jpg;*.jpeg|" +
                    "TIFF File|*.tiff|"
                    ;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    string ext = path.Split('.').LastOrDefault().ToLower();
                    img = Image.FromFile(path);
                    FrameDimension fd = new FrameDimension(img.FrameDimensionsList[0]);
                    int framecount = img.GetFrameCount(fd);
                    if (framecount > 1) 
                        Misc.GifToIndex(img, Data, framecount);
                    else 
                        Misc.GetIndexedItem(img, Data);
                }
            }
            catch(Exception ex)
            {
                try
                {
                    img = Misc.DecodePCX(path);
                    Misc.GetIndexedItem(img, Data);
                    flag = true;
                }
                catch(Exception Ex)
                {
                    MyMessageBox.Show(Constant.RunTime.ProgromTitle, Language.DICT["MsgFatalImportLoad"] + (flag ? Ex.Message : ex.Message));
                    btnImport.Enabled = false;
                    return;
                }
            }
            PreviewBox.Image = img;
            lblPath.Text = Language.DICT["ImportlblPrefix"] + path;
            btnImport.Enabled = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            GC.Collect();
            Close();
        }

        public PalFile Data { get; private set; } = new PalFile();
    }
}
