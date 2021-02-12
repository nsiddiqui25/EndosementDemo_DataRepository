using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod
{
    public partial class AdditionalEntity
    {
        public int EntityId { get; set; }

        public int MasterSheetId { get; set; }

        public string LegalName { get; set; }

        public string Dbaname { get; set; }

        public string Zip { get; set; }

        public DateTime? LastChangedDate { get; set; }

        public string LastChangedId { get; set; }

        public List<AdditionalEntityOwner> AdditionalEntityOwner { get; set; } = new List<AdditionalEntityOwner>();
    }
}
