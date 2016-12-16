using AssetManagementApp.Repository;
using AssetManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApp.Model
{
  
    public class ItemTypeModel : ModelBase
    {
        ItemTypeRepository itemRepository;
        ItemTypeViewModel iTVM;
        public ItemTypeModel(ItemTypeRepository rp) : base (rp)
        {
            itemRepository = rp;
            iTVM = new ItemTypeViewModel();
        }
    }
}
