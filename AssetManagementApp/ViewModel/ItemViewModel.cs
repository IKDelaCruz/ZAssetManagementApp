using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AssetManagementApp.ViewModel
{
    public class ItemViewModel : ViewModelBase
    {
        public enum ItemStatus
        {
            Available,
            Borrowed,
            Broken,
            Disposed
        }
        public enum ItemType
        {
            Asset,
            Licenses,
            Accesories,
            Consumable
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ItemType Type { get; set; }

        [Browsable(false)]
        public string Description { get; set; }
        public string AssetTag { get; set; }
        [Browsable(false)]
        public double PurchasePrice { get; set; }
        [Browsable(false)]
        public double LifeSpan { get; set; }
        [Browsable(false)]
        public DateTime PurchaseDate { get; set; }
        [Browsable(false)]
        public double Currentvalue { get; set; }
        public ItemStatus Status { get; set; }
        public string Borrower { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}

