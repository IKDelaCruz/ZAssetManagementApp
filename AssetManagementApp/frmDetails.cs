
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AssetManagementApp.Model;
using AssetManagementApp.ViewModel;
namespace AssetManagementApp
{
    public partial class frmDetails : frmBase
    {
        bool editable = false;

        ItemViewModel obj;
        string imageFilename;
        public frmDetails(ItemViewModel itm)
        {
            InitializeComponent();

            cbxType.DataSource = Enum.GetValues(typeof(ItemViewModel.ItemType));
            cbxStatus.DataSource = Enum.GetValues(typeof(ItemViewModel.ItemStatus));

            obj = itm;
            imageFilename = Path.GetDirectoryName(Application.ExecutablePath) + "\\images\\" + obj.Id + ".jpg";

            UpdateView();

         
        }
        private void UpdateView()
        {
            if (File.Exists(imageFilename))
                SetPicture((imageFilename), pbPicture);

            txtAssetTag.Text = obj.AssetTag;
         
            txtName.Text = obj.Name;
            cbxType.SelectedItem = obj.Type;
            txtDescription.Text = obj.Description;

            cbxStatus.SelectedItem = obj.Status;
            txtBorrower.Text = obj.Borrower;
            dtpReturnDate.Value = (obj.ReturnDate == DateTime.MinValue) ? DateTime.Now : obj.ReturnDate; ;

            txtPurchasePrice.Text = obj.PurchasePrice.ToString();
            dtpPurchaseDate.Value = (obj.PurchaseDate == DateTime.MinValue) ? DateTime.Now : obj.PurchaseDate;
            txtLifeSpan.Text = obj.LifeSpan.ToString();
            txtCurrentValue.Text = obj.Currentvalue.ToString();

            EnableInputs(editable);

        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Image | *.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var filename = dlg.FileName;
                System.IO.File.Copy(filename, imageFilename, true);

                UpdateView();
                ContainerOfModel.Instance.TransactionLogModel.Insert("Upload Image", obj.Name);

            }
        }
        public static void SetPicture(string filename, PictureBox pb)
        {

            Image currentImage;
            byte[] imageBytes = File.ReadAllBytes(filename);
            using (MemoryStream msImage = new MemoryStream(imageBytes))
            {
                currentImage = (Image.FromStream(msImage));
                pb.BackgroundImage = currentImage;
            }

        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if(btnLock.Text == "Unlock")
            {
                btnLock.Text = "Lock";
               
                btnSave.Visible = true;
                EnableInputs(true);

                editable = true;
            }
            else
            {
                btnLock.Text = "Unlock";
                
                btnSave.Visible = false;
                EnableInputs(false);

                editable = false;
            }
        }
        private void EnableInputs(bool enable)
        {
            txtAssetTag.ReadOnly = !enable;
            txtName.ReadOnly = !enable;
            cbxType.Enabled = enable;
            txtDescription.ReadOnly = !enable;

            cbxStatus.Enabled = enable;
            txtBorrower.ReadOnly = !enable;
            dtpReturnDate.Enabled = enable;

            txtPurchasePrice.ReadOnly = !enable;
            dtpPurchaseDate.Enabled = enable;
            txtLifeSpan.ReadOnly = !enable;
            txtCurrentValue.ReadOnly = !enable;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            obj.AssetTag = txtAssetTag.Text;
            obj.Name = txtName.Text;

            obj.Type = (ItemViewModel.ItemType)cbxType.SelectedValue;
            obj.Description = txtDescription.Text;

            obj.Status = (ItemViewModel.ItemStatus)cbxStatus.SelectedValue;
            obj.Borrower = txtBorrower.Text ;
            obj.ReturnDate = dtpReturnDate.Value;
            obj.PurchasePrice = double.Parse(txtPurchasePrice.Text);
            obj.PurchaseDate = dtpPurchaseDate.Value;
            obj.LifeSpan = double.Parse(txtLifeSpan.Text);
            obj.Currentvalue = double.Parse(txtCurrentValue.Text);

            ContainerOfModel.Instance.ItemModel.UpdateItem(obj);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var purchasePrice = obj.PurchasePrice;
            var lifeSpan = int.Parse(txtLifeSpan.Text);
            var purchaseDate = obj.PurchaseDate;

            var dur = DateTime.Now - purchaseDate;
            var daysUsed = dur.TotalDays;
            var daysLife = lifeSpan * 365;

            var currentValue = purchasePrice * ((daysLife - daysUsed) / daysLife);
            txtCurrentValue.Text = currentValue.ToString("n2");
        }
    }
}