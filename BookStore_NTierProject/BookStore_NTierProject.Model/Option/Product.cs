using BookStore_NTierProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Model.Option
{
    public class Product : CoreEntity
    {
        public decimal? Price { get; set; }
        public string Name { get; set; }
        public short? UnitInStock { get; set; }
        public string Quantity { get; set; }
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
