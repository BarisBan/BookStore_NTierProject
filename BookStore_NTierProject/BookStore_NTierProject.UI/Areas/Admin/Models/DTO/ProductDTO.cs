using BookStore_NTierProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore_NTierProject.UI.Areas.Admin.Models.DTO
{
    public class ProductDTO : BaseDTO
    {
        public decimal? Price { get; set; }
        public string Name { get; set; }
        public short? UnitInStock { get; set; }
        public string Quantity { get; set; }
        public Guid CategoryID { get; set; }
        public string CategoryName  { get; set; }

    }
}