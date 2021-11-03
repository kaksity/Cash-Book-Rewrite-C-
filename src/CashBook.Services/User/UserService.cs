using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashBook.Dtos.User;
using CashBook.DataAccess.User;
using CashBook.Models.User;

namespace CashBook.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void CreateNewUser(CreateUserDto dto)
        {
            var newUser = new UserModel
            {
                UserId = Guid.NewGuid().ToString(),
                UserName = dto.UserName.ToUpper(),
                UserPassword = dto.UserPassword,
                FullName = dto.FullName.ToUpper(),
                TelePhoneNumber = dto.TelePhoneNumber,
                EmailAddress = dto.EmailAddress.ToLower(),
                SecurityQuestion = dto.SecurityQuestion.ToUpper(),
                SecurityAnswer = dto.SecurityAnswer.ToUpper(),
                IsDeleted = false,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            _userRepository.CreateNewUser(newUser);
        }
    }
}
