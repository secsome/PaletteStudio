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
    public enum MyMessageBoxButtons
    {
        OK,
        YesNo,
        YesNoCancel
    }

    public partial class MyMessageBox : Form
    {
        public static DialogResult Show(string title, string content, MyMessageBoxButtons buttons = MyMessageBoxButtons.OK)
        {
            MyMessageBox myMessageBox = new MyMessageBox(title, content, buttons);
            return myMessageBox.ShowDialog();
        }

        public MyMessageBox(string title, string content, MyMessageBoxButtons buttons)
        {
            InitializeComponent();
            Text = title;
            rtxbMessage.Text = content;
            switch (buttons)
            {
                case MyMessageBoxButtons.OK:
                    btnOK.Visible = true;
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnCancel.Visible = false;
                    break;
                case MyMessageBoxButtons.YesNo:
                    btnOK.Visible = false;
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnCancel.Visible = false;
                    break;
                case MyMessageBoxButtons.YesNoCancel:
                    btnOK.Visible = false;
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    btnCancel.Visible = true;
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
