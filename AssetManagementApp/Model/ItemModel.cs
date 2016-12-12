using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementApp.Repository;
using AssetManagementApp.ViewModel;
namespace AssetManagementApp.Model
{
    public class ItemModel : ModelBase
    {
        ItemRepository itemRepository;
        ItemViewModel itemViewModel;
        public ItemModel(ItemRepository repo) : base(repo)
        {
            itemRepository = repo;
            itemViewModel = new ItemViewModel();
        }
        public void CreateNewItem(string name, string description, string assetTag, double purchasePrice)
        {
            int id = 1;
            if (itemRepository.Data != null)
            {
                var lastObj = itemRepository.Data.OrderByDescending(h => h.Id).FirstOrDefault();
                if (lastObj != null)
                {
                    id = lastObj.Id + 1;
                }
            }
            else
            {
                itemRepository.Data = new List<ItemViewModel>();
            }


            itemRepository.Data.Add(new ItemViewModel
            {
                Id = id,
                AssetTag = assetTag,
                Description = description,
                Name = name,
                PurchasePrice = purchasePrice,
                Status = ItemViewModel.ItemStatus.Available,
                PurchaseDate = DateTime.Now, LifeSpan = 5
            });
            SaveData();
        }
        public List<ItemViewModel> GetItems()
        {
            return itemRepository.Data;
        }
        public ItemViewModel GetItem(int id)
        {
            return itemRepository.Data.FirstOrDefault(h => h.Id == id);
        }
        public void BorrowItem(int id, string username, DateTime returnDate)
        {
            var item = itemRepository.Data.FirstOrDefault(h => h.Id == id);
            item.Status = ItemViewModel.ItemStatus.Borrowed;
            item.Borrower = username;
            item.ReturnDate = returnDate;

            SaveData();
        }

        public void Repair(int id, string username, DateTime returnDate)
        {
            var item = itemRepository.Data.FirstOrDefault(h => h.Id == id);
            item.Status = ItemViewModel.ItemStatus.Broken;
            item.Borrower = username;
            item.ReturnDate = returnDate;

            SaveData();
        }
        public void ReturnItem(int id)
        {
            var item = itemRepository.Data.FirstOrDefault(h => h.Id == id);
            item.Status = ItemViewModel.ItemStatus.Available;
            item.Borrower = "";
            item.ReturnDate = DateTime.Now;

            SaveData();
        }
        public void RetireItem(int id)
        {
            var item = itemRepository.Data.FirstOrDefault(h => h.Id == id);
            item.Status = ItemViewModel.ItemStatus.Disposed;
            item.Borrower = "";
            item.ReturnDate = DateTime.Now;

            SaveData();
        }
        public void UpdateItem(ItemViewModel itm)
        {
            var item = itemRepository.Data.FirstOrDefault(h => h.Id == itm.Id);
            item.AssetTag = itm.AssetTag;
            item.Name = itm.Name;
            item.Description = itm.Description;
            item.Type = itm.Type;
            item.Borrower = itm.Borrower;
            item.ReturnDate = itm.ReturnDate;
            item.Status = itm.Status;

            SaveData();
        }

    }

}
