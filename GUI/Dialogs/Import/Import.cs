using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
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

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Image img = new Bitmap(1, 1);
            string path = "";
            bool flag = false;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Title = Language.DICT["MainTitle"],
                    Filter =
                    "All Support Image Formats|*.pcx;*.gif;*.bmp;*.png;*.jpg;*.jpeg;*.tiff" +
                    "PCX File|*.pcx|" +
                    "GIF File|*.gif|" +
                    "BMP File|*.bmp|" +
                    "PNG File|*.png|" +
                    "JPG File|*.jpg;*.jpeg|" +
                    "TIFF File|*.tiff|"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                    string ext = path.Split('.').LastOrDefault().ToLower();
                    img = Image.FromFile(path);
                    FrameDimension fd = new FrameDimension(img.FrameDimensionsList[0]);
                    int framecount = img.GetFrameCount(fd);
                    if (framecount > 1)
                        Misc.GifToIndex(img, Data, framecount, (int)nudMaxNum.Value);
                    else
                        Misc.GetIndexedItem(img, Data, (int)nudMaxNum.Value);
                    btnImport.Enabled = true;
                    nudMaxNum.ReadOnly = true;
                    nudMaxNum.Increment = 0;
                }
                else
                {
                    nudMaxNum.Increment = 3;
                    nudMaxNum.ReadOnly = false;
                    btnImport.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                try
                {
                    img = Misc.DecodePCX(path);
                    Misc.GetIndexedItem(img, Data, (int)nudMaxNum.Value);
                    flag = true;
                    btnImport.Enabled = true;
                    nudMaxNum.ReadOnly = true;
                    nudMaxNum.Increment = 0;
                }
                catch(Exception Ex)
                {
                    MyMessageBox.Show(Language.DICT["MainTitle"], Language.DICT["MsgFatalImport"] + (flag ? Ex.Message : ex.Message));
                    btnImport.Enabled = false;
                    nudMaxNum.ReadOnly = false;
                    nudMaxNum.Increment = 3;
                    return;
                }
            }
            PreviewBox.Image = img;
            lblPath.Text = Language.DICT["ImportlblPrefix"] + path;
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            GC.Collect();
            Close();
        }

        public PalFile Data { get; private set; } = new PalFile();
    }
}
