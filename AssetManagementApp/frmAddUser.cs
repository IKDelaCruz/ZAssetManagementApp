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
using static AssetManagementApp.Model.UserModel;
using static AssetManagementApp.ViewModel.UserViewModel;

namespace AssetManagementApp
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void fmrAddUser_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = Enum.GetValues(typeof(UserType));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContainerOfModel.Instance.UserModel.CreateUser(txtUsername.Text, txtPassword.Text, (UserType)cbxType.SelectedValue);
            ContainerOfModel.Instance.TransactionLogModel.Insert("Add User", txtUsername.Text);
            MessageBox.Show("User added successfully");
            this.Close();
        }
    }
}
