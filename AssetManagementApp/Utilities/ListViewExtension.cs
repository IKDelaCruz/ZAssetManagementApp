using AssetManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementApp.Utilities
{
    public static class ListViewExtension
    {
        public static void LoadData(this ListView lv, List<ItemViewModel> items)
        {
            lv.Items.Clear();
            foreach(ItemViewModel iVL in items)
            {
                var newItem = new ListViewItem(iVL.Name);
                newItem.SubItems.Add(iVL.Id.ToString());
                newItem.SubItems.Add(iVL.Type.ToString());
                lv.Items.Add(newItem);
            }
        }
    }
}
