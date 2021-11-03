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

        public ReadUserDto GetUserByUsername(string username)
        {
            var userModel = _userRepository.GetUserByUsername(username.ToUpper());

            if (userModel == null) return null;

            var userReadDto = new ReadUserDto
            {
                UserId = userModel.UserId,
                UserName = userModel.UserName.ToUpper(),
                UserPassword = userModel.UserPassword,
                FullName = userModel.FullName.ToUpper(),
                TelePhoneNumber = userModel.TelePhoneNumber,
                EmailAddress = userModel.EmailAddress.ToLower(),
                SecurityQuestion = userModel.SecurityQuestion.ToUpper(),
                SecurityAnswer = userModel.SecurityAnswer.ToUpper(),
            };
            return userReadDto;
        }
    }
}
