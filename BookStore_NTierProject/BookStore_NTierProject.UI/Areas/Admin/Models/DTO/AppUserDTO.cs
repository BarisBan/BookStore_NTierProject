using BookStore_NTierProject.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_NTierProject.UI.Areas.Admin.Models.DTO
{
    public class AppUserDTO : BaseDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime? Birthdate { get; set; }
        public Role Role { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime? DateTime { get; set; }

    }
}