using AmmatraksOY_InvoiceApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmatraksOY_InvoiceApplication.ViewModel
{
    public class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public User Authenticate(string username, string password)
        {
            return users.Find(user => user.Username == username && user.Password == password);
        }
    }
}
