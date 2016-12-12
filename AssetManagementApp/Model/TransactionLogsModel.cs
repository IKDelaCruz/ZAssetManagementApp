using AssetManagementApp.Repository;
using AssetManagementApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApp.Model
{
    public class TransactionLogsModel : ModelBase
    {
        TransactionRepository transRepo;
        TransactionLogViewModel transViewModel;

        public TransactionLogsModel(TransactionRepository repo) : base(repo)
        {
            transRepo = repo;
            transViewModel = new TransactionLogViewModel();
        }

        public void Insert(TransactionLogViewModel log)
        {
            if (transRepo.Data == null)
            {
                transRepo.Data = new List<TransactionLogViewModel>();
            }

            transRepo.Data.Add(log);

            SaveData();
        }
        public void Insert(string type, string data)
        {
            if (transRepo.Data == null)
            {
                transRepo.Data = new List<TransactionLogViewModel>();
            }

            transRepo.Data.Add(new TransactionLogViewModel {
                ItemName = data,
                TransactionDate = DateTime.Now,
                TransactionType = type,
                Username = ContainerOfModel.Instance.UserViewModel.Username
            });

            SaveData();
        }
        public List<TransactionLogViewModel> GetLogs()
        {
            return transRepo.Data;
        }

    }
}
