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
using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Image img = new Bitmap(1, 1);
            string path = "";
            bool flag = false;
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
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
                    ImageFactory factory = new ImageFactory(preserveExifData: true);
                    factory.Load(path);
                    MemoryStream ms = new MemoryStream();
                    factory.Save(ms);
                    img = Image.FromStream(ms);
                    ms.Dispose();
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
                    MessageBox.Show(
                        "Something wrong occured while importing the image, the reason might be:\n" + (flag ? Ex.Message : ex.Message), 
                        "Palette Studio", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                        );
                    btnImport.Enabled = false;
                    return;
                }
            }
            PreviewBox.Image = img;
            lblPath.Text = path;
            btnImport.Enabled = true;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult = DialogResult.OK;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something wrong occured while importing the image, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GC.Collect();
            }
            Close();
        }

        public PalFile Data { get; private set; } = new PalFile();
    }
}
