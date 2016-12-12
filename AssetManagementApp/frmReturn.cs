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
    public partial class frmReturn : frmBase
    {
        ItemViewModel _item;
        

        public frmReturn(ItemViewModel borrowedItem)
        {
            InitializeComponent();

            _item = borrowedItem;
         
            txtAssetNumber.Text = _item.AssetTag;
            txtName.Text = _item.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContainerOfModel.Instance.ItemModel.ReturnItem(_item.Id);
            ContainerOfModel.Instance.TransactionLogModel.Insert("Return Item", _item.Name);
            this.Close();
        }
    }
}
