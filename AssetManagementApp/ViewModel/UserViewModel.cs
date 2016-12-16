using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagementApp.ViewModel
{
    [Serializable]
    public class UserViewModel : ViewModelBase
    {
        public enum UserType
        {
            Administrator,
            Custodian,
            User
        }

        public bool IsAuthenticated { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public UserType Type { get; set; }

       
    }
}
