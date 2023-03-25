using System;
using System.Windows.Forms;

namespace Bank_Blood.UI
{
    public partial class FormDonors : Form
    {
        public FormDonors()
        {
            InitializeComponent();
        }

        private void FormDonors_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormHome().ShowDialog();
            Close();
        }
    }
}
