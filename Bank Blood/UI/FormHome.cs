using Bank_Blood.UI;
using System;
using System.Windows.Forms;

namespace Bank_Blood
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FormUser().ShowDialog();
            Close();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FormDonors().ShowDialog();
            Close();
        }
    }
}
