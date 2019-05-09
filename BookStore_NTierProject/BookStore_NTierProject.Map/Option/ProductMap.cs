using BookStore_NTierProject.Core.Map;
using BookStore_NTierProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Map.Option
{
    public class ProductMap : CoreMap<Product>
    {
        public ProductMap()
        {

            ToTable("dto.Product");
            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.Quantity).IsRequired();
            Property(x => x.UnitInStock).IsRequired();



            HasRequired(x => x.Category)
                    .WithMany(x => x.Products)
                    .HasForeignKey(x => x.CategoryID)
                    .WillCascadeOnDelete(true);
        }
    }
}
