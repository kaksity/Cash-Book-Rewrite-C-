using CashBook.Dtos.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Services.User
{
    public interface IUserService
    {
        void CreateNewUser(CreateUserDto dto);
        ReadUserDto GetUserByUsername(string username);
        //UserModel GetUserByUserId(string userId);
        //void UpdateUser(UserModel model);
    }
}
