using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class AdditionalEntityOwner
    {
        public int EntityOwnerId { get; set; }
        public int? FkEntityId { get; set; }
        public string OwnerName { get; set; }
        public decimal? OwnerPercent { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public string LastChangedId { get; set; }

        public virtual AdditionalEntity FkEntity { get; set; }
    }
}
