using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class SsRole
    {
        public SsRole()
        {
            SsEldUserRole = new HashSet<SsEldUserRole>();
            SsRolePermission = new HashSet<SsRolePermission>();
        }

        public int SsRoleId { get; set; }
        public string RoleName { get; set; }
        public string AppName { get; set; }

        public virtual ICollection<SsEldUserRole> SsEldUserRole { get; set; }
        public virtual ICollection<SsRolePermission> SsRolePermission { get; set; }
    }
}
