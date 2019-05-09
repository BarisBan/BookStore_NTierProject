using BookStore_NTierProject.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Core.Entity
{
    public interface IEntity
    {
         Guid ID { get; set; }
         Guid MasterID { get; set; }
         DateTime? CreatedDate { get; set; }
         string CreatedComputerName { get; set; }
         string CreatedUserName { get; set; }
         Guid? CreatedBy { get; set; }
         string CreatedIP { get; set; }

         DateTime? ModifiedDate { get; set; }
         string ModifiedComputerName { get; set; }
         string ModifiedIP { get; set; }
         string ModifiedUserName { get; set; }
         Guid? ModifiedBy { get; set; }

         Status Status { get; set; }

    }
}
