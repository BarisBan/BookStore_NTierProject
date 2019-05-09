using BookStore_NTierProject.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_NTierProject.Core.Entity
{
    public class CoreEntity : IEntity
    {
        public Guid ID { get; set ; }
        public Guid MasterID { get ; set ; }

        private DateTime? _createDatetime = DateTime.Now;            
        public DateTime? CreatedDate { get { return _createDatetime; } set {_createDatetime= value; } }

        private string _createdComputerName = System.Security.Principal.WindowsIdentity.GetCurrent().Name; 
        public string CreatedComputerName { get { return _createdComputerName; } set { _createdComputerName = value; } }

        private string _createdUserName = Environment.MachineName;
        public string CreatedUserName { get { return _createdUserName; } set { _createdUserName = value; } }

        private string _createdIP = "123";
        public string CreatedIP { get { return _createdIP; } set { _createdIP = value; } }
        public Guid? CreatedBy { get ; set ; }

        public DateTime? ModifiedDate { get ; set ; }
        public string ModifiedComputerName { get ; set ; }
        public string ModifiedIP { get ; set ; }
        public string ModifiedUserName { get ; set ; }
        public Guid? ModifiedBy { get ; set ; }

        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }
    }
}
