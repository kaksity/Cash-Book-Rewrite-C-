using CashBook.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.DataAccess.User
{
    public interface IUserRepository
    {
        void CreateNewUser(UserModel model);
        UserModel GetUserByUsername(string username);
        UserModel GetUserByUserId(string userId);
        List<UserModel> GetAllUsers();
        void UpdateUserWithPassword(UserModel model);
        void UpdateUserWithoutPassword(UserModel model);
    }
}
