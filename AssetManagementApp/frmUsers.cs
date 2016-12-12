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
using AssetManagementApp.ViewModel;
namespace AssetManagementApp
{
    public partial class frmUsers : frmBase
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            UpdateView();
        }
        private void UpdateView()
        {
            dvItems.DataSource = null;
            dvItems.DataSource = ContainerOfModel.Instance.UserModel.GetUsers();

        }
    }
}
