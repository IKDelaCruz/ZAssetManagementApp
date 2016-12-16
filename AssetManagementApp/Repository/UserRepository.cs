using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementApp.ViewModel;
using System.Xml.Serialization;
using System.IO;

namespace AssetManagementApp.Repository
{
 
    [Serializable]
    public class UserRepository : RepositoryBase
    {

       

        public override void Load()
        {
            if (!ExistingData())
                return;

            Data = new List<ViewModelBase>();
            XmlSerializer serializer = new XmlSerializer(typeof(UserRepository));
            StreamReader reader = new StreamReader(typeof(UserRepository).ToString());

            var obj = ((UserRepository)serializer.Deserialize(reader));
            Data = obj.Data;
  
            reader.Close();
        }
        public void CreateDefaultUser()
        {

            Data = new List<ViewModelBase>();
            Data.Add(new UserViewModel { Username = "admin", Password = "admin", IsAuthenticated = false});
            Save("AssetManagementApp.Model");
        }

        public override List<ViewModelBase> GetData()
        {
            return Data;
        }
    }
}
