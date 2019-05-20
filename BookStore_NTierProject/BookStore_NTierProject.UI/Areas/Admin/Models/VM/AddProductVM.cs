using BookStore_NTierProject.Model.Option;
using BookStore_NTierProject.UI.Areas.Admin.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_NTierProject.UI.Areas.Admin.Models.VM
{
    public class AddProductVM
    {
        public AddProductVM()
        {
            Categories = new List<Category>();
            Products = new ProductDTO();
        }

        public List<Category> Categories { get; set; }
        public ProductDTO Products { get; set; }

    }
}