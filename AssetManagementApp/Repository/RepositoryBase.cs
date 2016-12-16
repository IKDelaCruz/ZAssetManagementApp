using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AssetManagementApp.ViewModel;
using System.Xml.Serialization;

namespace AssetManagementApp.Repository
{
    [XmlInclude(typeof(UserRepository))]
    [Serializable]
    public abstract class RepositoryBase
    {
        public List<ViewModelBase> Data { get; set; }

        public  void Save(string type)
        {
            TextWriter writer = new StreamWriter(this.GetType().ToString());
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());
            x.Serialize(writer, this);
            writer.Close();
        }
        public bool ExistingData()
        {
            return (File.Exists(this.GetType().ToString()));
        }
        public abstract List<ViewModel.ViewModelBase> GetData();

        public abstract void Load();
    }
}
