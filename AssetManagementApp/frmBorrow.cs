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
    public partial class frmBorrow : frmBase
    {
        ItemViewModel _item;
        string _borrower;
        bool _isRepair;
        public frmBorrow()
        {
            InitializeComponent();
          

        }
        public frmBorrow(ItemViewModel borrowedItem, string borrower, bool isRepair = false)
        {
            InitializeComponent();

            _item = borrowedItem;
            _borrower = borrower;
            txtAssetNumber.Text = _item.AssetTag;
            txtName.Text = _item.Name;

            _isRepair = isRepair;

            if (isRepair)
            {
                Text = "Asset Management - Repair Item";
            }
        }
        private void frmReturn_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_isRepair)
            {
                ContainerOfModel.Instance.ItemModel.Repair(_item.Id, _borrower, dtpReturnDate.Value.Date);
                ContainerOfModel.Instance.TransactionLogModel.Insert("Repair Item", _item.Name);
            }
            else
            {
                ContainerOfModel.Instance.ItemModel.BorrowItem(_item.Id, _borrower, dtpReturnDate.Value.Date);
                ContainerOfModel.Instance.TransactionLogModel.Insert("Borrow Item", _item.Name);
            }
            this.Close();
        }
    }
}
