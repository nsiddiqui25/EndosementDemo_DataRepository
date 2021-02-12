using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class SsRolePermission
    {
        public int SsRolePermissionId { get; set; }
        public int SsPermissionId { get; set; }
        public int SsRoleId { get; set; }
        public bool? View { get; set; }
        public bool? Add { get; set; }
        public bool? Edit { get; set; }
        public bool? Delete { get; set; }
        public bool? Other { get; set; }
        public string OtherDescription { get; set; }

        public virtual SsPermission SsPermission { get; set; }
        public virtual SsRole SsRole { get; set; }
    }
}
