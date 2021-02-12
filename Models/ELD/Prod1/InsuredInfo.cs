using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class InsuredInfo
    {
        public InsuredInfo()
        {
            AcctTrans = new HashSet<AcctTrans>();
        }

        public int InsuredInfoId { get; set; }
        public string InsuredName { get; set; }
        public string InsuredNamechk { get; set; }
        public string InsuredAddress { get; set; }
        public string InsuredCity { get; set; }
        public string InsuredSta { get; set; }
        public string InsuredZip { get; set; }
        public string InsuredNotes { get; set; }
        public string Ticker { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public string LastChangedId { get; set; }
        public string InsuredAddresschk { get; set; }
        public int? MasterInsuredId { get; set; }
        public byte[] RowVersion { get; set; }
        public byte[] Ein { get; set; }
        public bool? EinVerified { get; set; }
        public string InsuredDbaName { get; set; }
        public string InsuredCounty { get; set; }
        public string InsuredNamechkFull { get; set; }
        public string InsuredMailingAddress { get; set; }
        public string InsuredMailingCity { get; set; }
        public string InsuredMailingSta { get; set; }
        public string InsuredMailingZip { get; set; }
        public string InsuredMailingCounty { get; set; }

        public virtual ICollection<AcctTrans> AcctTrans { get; set; }
    }
}
