using PaletteStudio.FileSystem;
using PaletteStudio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "PCX File|*.pcx|" +
                    "GIF File|*.gif|" +
                    "BMP File|*.bmp|" +
                    "PNG File|*.png|" +
                    "JPG File|*.jpg;*.jpeg|" +
                    "All Support Image Formats|*.pcx;*.gif;*.bmp;*.png;*.jpg;*.jpeg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog.FileName;
                    string ext = path.Split('.').LastOrDefault().ToLower();
                    Image img = new Bitmap(1, 1);
                    switch (ext)
                    {
                        case "png":
                        case "jpg":
                        case "jpeg":
                        case "bmp":
                            img = Image.FromFile(path);
                            Misc.GetIndexedItem(img, Data);
                            break;
                        case "gif":
                            img = Image.FromFile(path);
                            Misc.GetIndexedImagePal(img, Data);
                            break;
                        case "pcx":
                            img = Misc.DecodePCX(path);
                            Misc.GetIndexedItem(img, Data);
                            break;
                        default:
                            throw new Exception("Unsupported image format!");
                    }
                    PreviewBox.Image = img;
                    lblPath.Text = path;
                    btnImport.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something wrong occured while importing the image, the reason might be:\n" + ex.Message, "Palette Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnImport.Enabled = false;
                return;
            }
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
