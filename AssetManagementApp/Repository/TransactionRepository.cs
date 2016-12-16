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
   public class TransactionRepository : RepositoryBase
    {
       

        public override List<ViewModelBase> GetData()
        {
            throw new NotImplementedException();
        }

        public override void Load()
        {
            if (!ExistingData())
                return;

            Data = new List<ViewModelBase>();
            XmlSerializer serializer = new XmlSerializer(typeof(TransactionRepository));
            StreamReader reader = new StreamReader(typeof(TransactionRepository).ToString());

            var obj = ((TransactionRepository)serializer.Deserialize(reader));
            Data = obj.Data;

            reader.Close();
        }
    }
}
