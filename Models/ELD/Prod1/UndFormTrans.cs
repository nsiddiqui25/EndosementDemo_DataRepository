using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class UndFormTrans
    {
        public UndFormTrans()
        {
            UndFormBlanks = new HashSet<UndFormBlanks>();
        }

        public int FormTransId { get; set; }
        public int? AcctId { get; set; }
        public int? FormVersionId { get; set; }
        public int? AcctTransId { get; set; }
        public string FormCustomName { get; set; }
        public string IssuePageNo { get; set; }
        public string Qstatus { get; set; }
        public string Bstatus { get; set; }
        public string Istatus { get; set; }
        public string Mstatus { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public string LastChangedId { get; set; }
        public DateTime? TransEffectiveDate { get; set; }
        public bool? Optional { get; set; }
        public string Ano { get; set; }
        public DateTime? Adate { get; set; }
        public string Fno { get; set; }
        public byte[] RowVersion { get; set; }
        public string FormCategory { get; set; }
        public string InFrom { get; set; }

        public virtual ICollection<UndFormBlanks> UndFormBlanks { get; set; }
    }
}
