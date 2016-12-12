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
        public List<TransactionLogViewModel> Data { get; set; }

        public override void Load()
        {
            if (!ExistingData())
                return;

            Data = new List<TransactionLogViewModel>();
            XmlSerializer serializer = new XmlSerializer(typeof(TransactionRepository));
            StreamReader reader = new StreamReader(typeof(TransactionRepository).ToString());

            var obj = ((TransactionRepository)serializer.Deserialize(reader));
            Data = obj.Data;

            reader.Close();
        }
    }
}
