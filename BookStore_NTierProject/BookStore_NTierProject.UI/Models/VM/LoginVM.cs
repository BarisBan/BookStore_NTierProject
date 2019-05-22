using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore_NTierProject.UI.Models.VM
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Wrong User Name!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Wrong Password!")]
        public string Password { get; set; }
    }
}