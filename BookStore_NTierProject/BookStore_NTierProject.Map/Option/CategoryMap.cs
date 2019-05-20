using BookStore_NTierProject.Core.Map;
using BookStore_NTierProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Map.Option
{
    public class CategoryMap : CoreMap<Category>
    {

        public CategoryMap()
        {
            ToTable("dto.Categories");
            Property(x => x.Name).IsOptional();
            Property(x => x.Description).IsOptional();

            HasMany(x => x.Products).WithRequired(x => x.Category).HasForeignKey(x => x.CategoryID);
        }
      
    }
}


