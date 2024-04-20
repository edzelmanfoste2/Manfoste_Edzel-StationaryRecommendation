using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Models;
using StationaryDataLayer;
namespace StationaryBusiness
{
    public class UsersLogic
    {
        public bool VerifyUsers(string username)
        {
            UsersData user = new UsersData();
            var result = user.GetUsers(username);

            return result.username != null ? true : false;
        }
    }
}
