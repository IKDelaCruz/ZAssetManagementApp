using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssetManagementApp.Repository
{
    public abstract class RepositoryBase
    {
        
        public  void Save()
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
        public abstract void Load();
    }
}
