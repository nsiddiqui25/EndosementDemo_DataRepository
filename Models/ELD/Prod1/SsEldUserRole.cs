using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class SsEldUserRole
    {
        public int SsUserRoleId { get; set; }
        public int SsRoleId { get; set; }
        public int SsEldUserId { get; set; }

        public virtual EldUsers SsEldUser { get; set; }
        public virtual SsRole SsRole { get; set; }
    }
}
