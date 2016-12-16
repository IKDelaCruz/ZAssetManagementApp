using AssetManagementApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagementApp.ViewModel;

namespace AssetManagementApp.Model
{
    public class UserModel : ModelBase
    {

        UserRepository userReporsitory;
        UserViewModel userViewModel;

        public UserModel(UserRepository userRepository) : base(userRepository)
        {
            this.userReporsitory = userRepository;
            userViewModel = new UserViewModel();
        }
        public UserViewModel AuthenticateUser(string username, string password)
        {
            if (userReporsitory.Data == null || userReporsitory.Data.Count == 0)
            {
                userReporsitory.CreateDefaultUser();
            }
            var concreteUser = userReporsitory.Data.ConvertAll(h => (UserViewModel)h);
            var user = concreteUser.FirstOrDefault(h => h.Username == username && h.Password == password);
            if (user != null)
            {
                userViewModel.IsAuthenticated = true;
                userViewModel.Username = username;
            }

            return userViewModel;
        }
        public UserViewModel GetUserInformation(string username)
        {
            return userViewModel;
        }

        public UserViewModel CreateUser(string username, string password, UserViewModel.UserType usertype)
        {
            var obj = new UserViewModel
            {
                Username = username,
                Password = password,
                Type = usertype,
                IsAuthenticated = false,

            };

            userReporsitory.Data.Add(obj);
            SaveData("AssetManagementApp.Model");

            return obj;
        }

        public List<UserViewModel> GetUsers()
        {
            return userReporsitory.Data.ConvertAll(h=> (UserViewModel)h);
        }

    }
}
