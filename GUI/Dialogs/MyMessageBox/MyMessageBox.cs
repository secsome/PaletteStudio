using System;
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
            btnOK.Text = Language.DICT["MsgbtnOK"];
            btnYes.Text = Language.DICT["MsgbtnYes"];
            btnNo.Text = Language.DICT["MsgbtnNo"];
            btnCancel.Text = Language.DICT["MsgbtnCancel"];
            switch (buttons)
            {
                case MyMessageBoxButtons.OK:
                    btnOK.Visible = true;
                    btnYes.Visible = false;
                    btnNo.Visible = false;
                    btnCancel.Visible = false;
                    break;
                case MyMessageBoxButtons.YesNo:
                    btnYes.Location = btnNo.Location;
                    btnNo.Location = btnCancel.Location;
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

        private void BtnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
