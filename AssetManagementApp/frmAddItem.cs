using AssetManagementApp.Model;
using AssetManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AssetManagementApp.ViewModel.ItemViewModel;

namespace AssetManagementApp
{
    public partial class frmAddItem : frmBase
    {
        public frmAddItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContainerOfModel.Instance.ItemModel.CreateNewItem(txtName.Text, txtDescription.Text, txtAssetTag.Text, double.Parse(txtPurchasePrice.Text));
            ContainerOfModel.Instance.TransactionLogModel.Insert("Add Item", txtName.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            cbxType.DataSource = Enum.GetValues(typeof(ItemTypeViewModel.PrimaryItemType));
        }
    }
}
