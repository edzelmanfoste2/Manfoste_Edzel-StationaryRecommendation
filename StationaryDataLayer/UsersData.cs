using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryDataLayer
{
    public class UsersData
    {
        public UsersData()
        {
            usersAccount();
        }

        List<UsersModel> users = new List<UsersModel>();
        private void usersAccount()
        {
            UsersModel user1 = new UsersModel { username = "Tala" };
            UsersModel user2 = new UsersModel { username = "Edzel" };
            UsersModel user3 = new UsersModel { username = "User3" };

            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
        }

        public UsersModel GetUsers(string username)
        {
            UsersModel registeredUsers = new UsersModel();

            foreach (var user in users)
            {
                if (username == user.username)
                {
                    registeredUsers = user;
                }
            }
            return registeredUsers;
        }
    }
}
