using System.Windows.Forms;

namespace PaletteStudio.GUI.Dialogs
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void palPanel1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void palPanel1_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
