using AssetManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AssetManagementApp.Repository
{
    public class ItemRepository : RepositoryBase
    {
        public List<ItemViewModel> Data { get; set; }
  
        public override void Load()
        {
            if (!ExistingData())
                return;

            Data = new List<ItemViewModel>();
            XmlSerializer serializer = new XmlSerializer(typeof(ItemRepository));
            StreamReader reader = new StreamReader(typeof(ItemRepository).ToString());

            var obj = ((ItemRepository)serializer.Deserialize(reader));
            Data = obj.Data;

            reader.Close();
        }
    }
}
