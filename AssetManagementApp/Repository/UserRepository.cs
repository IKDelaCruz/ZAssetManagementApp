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
    public class UserRepository : RepositoryBase
    {

        public List<UserViewModel> Data { get; set; }

        public override void Load()
        {
            Data = new List<UserViewModel>();
            XmlSerializer serializer = new XmlSerializer(typeof(UserRepository));
            StreamReader reader = new StreamReader(typeof(UserRepository).ToString());

            var obj = ((UserRepository)serializer.Deserialize(reader));
            Data = obj.Data;
  
            reader.Close();
        }
        public void CreateDefaultUser()
        {
            Data = new List<UserViewModel>();
            Data.Add(new UserViewModel { Username = "admin", Password = "admin", IsAuthenticated = false});
            Save();
        }
    }
}
