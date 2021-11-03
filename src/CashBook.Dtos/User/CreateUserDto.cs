using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Dtos.User
{
    public class CreateUserDto
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FullName { get; set; }
        public string TelePhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
    }
}
