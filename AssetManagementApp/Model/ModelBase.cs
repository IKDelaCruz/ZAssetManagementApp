using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementApp.ViewModel;
using AssetManagementApp.Repository;

namespace AssetManagementApp.Model
{
    public class ModelBase
    {
        public RepositoryBase Repostiory;
     
        public ModelBase(RepositoryBase rb)
        {
            Repostiory = rb;
            Repostiory.Load();
        }
      
        public void SaveData(string type)
        {
            Repostiory.Save(type);
        }

    }
}
