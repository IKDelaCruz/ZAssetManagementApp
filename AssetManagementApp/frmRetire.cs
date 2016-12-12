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

namespace AssetManagementApp
{
    public partial class frmRetire : frmBase
    {
        ItemViewModel _item;


        public frmRetire(ItemViewModel borrowedItem)
        {
            InitializeComponent();

            _item = borrowedItem;

            txtAssetNumber.Text = _item.AssetTag;
            txtName.Text = _item.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ContainerOfModel.Instance.ItemModel.RetireItem(_item.Id);
            ContainerOfModel.Instance.TransactionLogModel.Insert("Retire Item", _item.Name);
            this.Close();
        }
    }
}
