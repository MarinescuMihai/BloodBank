using Bank_Blood.BusinessLogicLayer;
using Bank_Blood.DataAdapters;
using System;
using System.Windows.Forms;

namespace Bank_Blood.UI
{
    public partial class FormUser : Form
    {
        #region private

        private AppUser user = new AppUser();
        private AppUserDataAdapter userDataAdapter = new AppUserDataAdapter();
        private string profilePicture = string.Empty;

        private void CleanText()
        {
            tbFullName.Text = string.Empty;
            tbEmail.Text = string.Empty;
            tbUserName.Text = string.Empty;
            tbPassword.Text = string.Empty;
            tbTelephone.Text = string.Empty;
            tbAddress.Text = string.Empty;
            tbUserId.Text = string.Empty;
        }

        private void UpdateDBV()
        {
            var datatable = userDataAdapter.Select();
            dbvUsers.DataSource = datatable;
        }

        private void PopulateUserWithDataFromTextBloxs()
        {
            user.UserId = string.IsNullOrEmpty(tbUserId.Text) ? 0 : int.Parse(tbUserId.Text);
            user.FullName = tbFullName.Text;
            user.Email = tbEmail.Text;
            user.UserName = tbUserName.Text;
            user.Password = tbPassword.Text;
            user.Contact = tbTelephone.Text;
            user.Address = tbAddress.Text;
            user.DataAdded = DateTime.Now;
            user.ProfilePicture = "unknown";
        }

        #endregion


        public FormUser()
        {
            InitializeComponent();
        }

        private void labelUsers_Click(object sender, EventArgs e)
        {
            Hide();
            new FormHome().ShowDialog();
            Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            PopulateUserWithDataFromTextBloxs();

            var success = userDataAdapter.Insert(user);

            if (success)
            {
                MessageBox.Show("New user added successfully.");

                UpdateDBV();
                CleanText();
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void dbvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            tbUserId.Text = dbvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            tbUserName.Text = dbvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            tbEmail.Text = dbvUsers.Rows[rowIndex].Cells[2].Value.ToString(); ;
            tbPassword.Text = dbvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            tbFullName.Text = dbvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            tbTelephone.Text = dbvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            tbAddress.Text = dbvUsers.Rows[rowIndex].Cells[6].Value.ToString();

        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            var data = userDataAdapter.Select();
            dbvUsers.DataSource = data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            user.UserId = int.Parse(tbUserId.Text);
            var success = userDataAdapter.DeleteUser(user);

            if (success)
            {
                MessageBox.Show("User deleted.");
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }

            CleanText();
            UpdateDBV();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PopulateUserWithDataFromTextBloxs();
            var success = userDataAdapter.Update(user);

            if (success)
            {
                MessageBox.Show("User Updated.");
            }
            else
            {
                MessageBox.Show("Something went wrong.");
            }

            CleanText();
            UpdateDBV();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CleanText();
        }

        private void tnSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tnSearchUser.Text))
            {
                dbvUsers.DataSource = userDataAdapter.Search(tnSearchUser.Text);
            }
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
