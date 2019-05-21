using BookStore_NTierProject.Core.Map;
using BookStore_NTierProject.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Map.Option
{
    public class AppUserMap : CoreMap<AppUser>
    {
        public AppUserMap()
        {
            ToTable("dbo.Users");
            Property(x => x.FirstName).HasColumnName("FirstName").HasMaxLength(20).IsRequired();
            Property(x => x.LastName).HasColumnName("LastName").HasMaxLength(20).IsRequired();
            Property(x => x.UserName).HasColumnName("UserName").HasMaxLength(10).IsRequired();
            Property(x => x.Password).HasColumnName("Pass").HasMaxLength(10).IsRequired();
            Property(x => x.PhoneNumber).HasColumnName("Phone").HasMaxLength(13).IsRequired();
            Property(x => x.Address).HasColumnName("Address").IsRequired();
            Property(x => x.Gender).HasColumnName("Gender").IsRequired();
            Property(x => x.Role).HasColumnName("Role").IsRequired();
            Property(x => x.Birthdate).HasColumnType("datetime2").HasColumnName("Birthdate").IsOptional();
            Property(x => x.DateTime).HasColumnName("DateTime").IsOptional();
        }

    }
}
