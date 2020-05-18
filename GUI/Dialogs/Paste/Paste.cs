using PaletteStudio.FileSystem;
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
    public partial class Paste : Form
    {
        private PalFile OriginPal = new PalFile();
        private List<ValueTuple<byte, byte, byte, byte>> OriginDatas = new List<(byte, byte, byte, byte)>();
        private bool IsOrigin = true;
        private bool IsToEnd = true;


        public Paste(PalFile palFile, List<ValueTuple<byte, byte, byte, byte>> data)
        {
            InitializeComponent();
            OriginDatas = data;
            OriginPal = palFile;
            for (int i = 0; i < 256; i++) PreviewPanel.PalSource[(byte)i] = OriginPal[(byte)i];
            foreach (Control c in groupBox2.Controls) c.Enabled = false;
        }

        public Paste()
        {
            InitializeComponent();
        }

        private void rbtnPasteTo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnOrigin.Checked)
            {
                foreach (Control c in groupBox2.Controls) c.Enabled = false;
                IsOrigin = true;
            }
            else
            {
                foreach (Control c in groupBox2.Controls) c.Enabled = true;
                IsOrigin = false;
            }
        }
    }
}
