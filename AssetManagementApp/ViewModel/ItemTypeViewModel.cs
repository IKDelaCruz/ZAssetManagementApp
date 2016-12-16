using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApp.ViewModel
{
   
    public class ItemTypeViewModel : ViewModelBase
    {
        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public enum PrimaryItemType
        {
            Asset,
            Licenses,
            Accesories,
            Consumable
        }


    }
}
