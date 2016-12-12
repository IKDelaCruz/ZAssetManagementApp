using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementApp.Repository;
using AssetManagementApp.ViewModel;

namespace AssetManagementApp.Model
{
    public class ContainerOfModel
    {
        private static ContainerOfModel instance;

        public UserModel UserModel { get; set; }
        public UserViewModel UserViewModel { get; set; }

        public ItemModel ItemModel { get; set; }
        public ItemViewModel ItemViewModel { get; set; }
        public TransactionLogsModel TransactionLogModel { get; set; }


        private ContainerOfModel()
        {
            UserRepository ur = new UserRepository();
            ItemRepository ir = new ItemRepository();
            TransactionRepository tr = new TransactionRepository();

            UserModel = new UserModel(ur);
            UserViewModel = new UserViewModel();
            ItemModel = new ItemModel(ir);
            ItemViewModel = new ItemViewModel();
            TransactionLogModel = new TransactionLogsModel(tr);

        }

        public static ContainerOfModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ContainerOfModel();
                }
                return instance;
            }
        }
    }
}
