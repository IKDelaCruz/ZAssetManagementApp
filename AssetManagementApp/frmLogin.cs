using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementApp.Model;

namespace AssetManagementApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            UserLogin();
        }
        private void UserLogin()
        {
            var result = ContainerOfModel.Instance.UserModel.AuthenticateUser(txtUsername.Text, txtPassword.Text);
            ContainerOfModel.Instance.UserViewModel = result;

            if (result.IsAuthenticated)
            {
                ContainerOfModel.Instance.TransactionLogModel.Insert(new ViewModel.TransactionLogViewModel
                {
                    ItemName = "Login",
                    TransactionDate = DateTime.Now,
                    TransactionType = "Login",
                    Username = txtUsername.Text

                });
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("Invalid Username and Password!");
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                UserLogin();
            }
        }
    }
}
