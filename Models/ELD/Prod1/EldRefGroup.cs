﻿using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class EldRefGroup
    {
        public int GroupId { get; set; }
        public int DepartmentId { get; set; }
        public string GroupName { get; set; }
        public string GroupAbbreviatedName { get; set; }
        public int? GroupHeadId { get; set; }
        public byte[] GroupRowVersion { get; set; }

        public virtual EldDepartment Department { get; set; }
    }
}
