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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ContainerOfModel.Instance.UserViewModel.IsAuthenticated)
            {
                ContainerOfModel.Instance.UserViewModel.IsAuthenticated = false;
                UserLogin();
            }
            else
            {
                UserLogin();
            }

        }
        private void UpdateView()
        {
            if (ContainerOfModel.Instance.UserViewModel.IsAuthenticated)
            {
                tssStatus.Text = "Login as [ " + ContainerOfModel.Instance.UserViewModel.Username + " ]";
                loginToolStripMenuItem.Text = "Logout";
            }
            else
            {
                tssStatus.Text = "Please Login";
                loginToolStripMenuItem.Text = "Login";
                UserLogin();
            }

            dvItems.DataSource = null;
            dvItems.DataSource = ContainerOfModel.Instance.ItemModel.GetItems();
        }
        private void UserLogin()
        {
            var dlg = new frmLogin();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                UpdateView();
            }
            else
            {
                Application.Exit();
            }


        }
        private void doAddITem(object sender, EventArgs e)
        {
            new frmAddItem().ShowDialog();
            UpdateView();
        }

        private void doBorrowItem(object sender, EventArgs e)
        {
            var id = dvItems.SelectedRows[0].Cells[0].Value.ToString();
            var obj = ContainerOfModel.Instance.ItemModel.GetItem(int.Parse(id));

            new frmBorrow(obj, ContainerOfModel.Instance.UserViewModel.Username).ShowDialog();

            UpdateView();
        }

        private void doAddUser(object sender, EventArgs e)
        {
            new frmAddUser().ShowDialog();
        }

        private void doReturnItem(object sender, EventArgs e)
        {
            var id = dvItems.SelectedRows[0].Cells[0].Value.ToString();
            var obj = ContainerOfModel.Instance.ItemModel.GetItem(int.Parse(id));

            new frmReturn(obj).ShowDialog();
            UpdateView();
        }

        private void doApplicationExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doViewItem(object sender, EventArgs e)
        {
            var id = dvItems.SelectedRows[0].Cells[0].Value.ToString();
            var obj = ContainerOfModel.Instance.ItemModel.GetItem(int.Parse(id));

            new frmDetails(obj).ShowDialog();
            UpdateView();
        }

        private void doRepairItem(object sender, EventArgs e)
        {
            var id = dvItems.SelectedRows[0].Cells[0].Value.ToString();
            var obj = ContainerOfModel.Instance.ItemModel.GetItem(int.Parse(id));

            new frmBorrow(obj, ContainerOfModel.Instance.UserViewModel.Username, true).ShowDialog();

            UpdateView();
        }

        private void dvItems_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmsItems_Opening(object sender, CancelEventArgs e)
        {
            var id = dvItems.SelectedRows[0].Cells[0].Value.ToString();
            var obj = ContainerOfModel.Instance.ItemModel.GetItem(int.Parse(id));
            if (obj.Status == ViewModel.ItemViewModel.ItemStatus.Available)
            {
                cmsTsBorrow.Visible = true;
                cmsTsRepair.Visible = true;
                cmsTsReturn.Visible = false;
                cmsTsRetire.Visible = true;
            }
            if (obj.Status == ViewModel.ItemViewModel.ItemStatus.Borrowed)
            {
                cmsTsBorrow.Visible = false;
                cmsTsRepair.Visible = false;
                cmsTsReturn.Visible = true;
                cmsTsRetire.Visible = false;
            }
            if (obj.Status == ViewModel.ItemViewModel.ItemStatus.Broken)
            {
                cmsTsBorrow.Visible = false;
                cmsTsRepair.Visible = false;
                cmsTsReturn.Visible = true;
                cmsTsRetire.Visible = true;
            }
            if (obj.Status == ViewModel.ItemViewModel.ItemStatus.Disposed)
            {
                cmsTsBorrow.Visible = false;
                cmsTsRepair.Visible = false;
                cmsTsReturn.Visible = false;
                cmsTsRetire.Visible = false;
            }
        }

        private void doRetire(object sender, EventArgs e)
        {
            var id = dvItems.SelectedRows[0].Cells[0].Value.ToString();
            var obj = ContainerOfModel.Instance.ItemModel.GetItem(int.Parse(id));

            new frmRetire(obj).ShowDialog();

            UpdateView();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUsers().ShowDialog();

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTransactionLogs().ShowDialog();
        }
    }
}
