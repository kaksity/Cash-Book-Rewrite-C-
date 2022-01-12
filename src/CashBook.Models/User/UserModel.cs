﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashBook.Models.User
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string OrganizationName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string  FullName { get; set; }
        public string TelePhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }
        public byte[] Photo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}