﻿using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class CorpOwner
    {
        public int CorpOwnerId { get; set; }
        public int MasterSheetId { get; set; }
        public string CorpOwnerName { get; set; }
        public decimal? CorpOwnerPercent { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public string LastChangedId { get; set; }
    }
}
