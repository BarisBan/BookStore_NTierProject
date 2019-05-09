using BookStore_NTierProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Core.Map
{
    public class CoreMap<T> : EntityTypeConfiguration<T> where T : CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.CreatedUserName).HasColumnName("CreatedUserName").HasMaxLength(50).IsRequired();
            Property(x => x.CreatedComputerName).HasColumnName("CreatedComputer").HasMaxLength(50).IsRequired();
            Property(x => x.CreatedBy).HasColumnName("CreatedBY").IsRequired();
            Property(x => x.CreatedIP).HasColumnName("CreatedIP").HasMaxLength(20).IsRequired();
            Property(x => x.CreatedDate).HasColumnName("CreateDate").IsRequired();
            Property(x => x.ModifiedUserName).HasColumnName("ModifiedUserName").HasMaxLength(50).IsOptional();
            Property(x => x.ModifiedComputerName).HasColumnName("ModifiedComputerName").HasMaxLength(50).IsOptional();
            Property(x => x.ModifiedBy).HasColumnName("ModifiedBY").IsOptional();
            Property(x => x.ModifiedIP).HasColumnName("ModifiedIP").HasMaxLength(20).IsOptional();
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsOptional();
        }

    }
}
