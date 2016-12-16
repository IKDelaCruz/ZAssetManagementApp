using AssetManagementApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementApp
{
    public partial class frmUserSelection : frmBase 
    {
        public string SelectedUsername { get; set; }
        public frmUserSelection()
        {
            InitializeComponent();
            LoadEmployees();
        }
        private void LoadEmployees()
        {
            cbxEmployees.DataSource = ContainerOfModel.Instance.UserModel.GetUsers().Select(h => h.Username).ToList();
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectedUsername = cbxEmployees.SelectedValue.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
