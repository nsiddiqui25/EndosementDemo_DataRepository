using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class UndFormVersion
    {
        public int FormMasterId { get; set; }
        public int FormVersionId { get; set; }
        public string FormVersionSuf { get; set; }
        public string FormVersionNo { get; set; }
        public string ReferenceNo { get; set; }
        public string FormDisplay { get; set; }
        public string FormName { get; set; }
        public string FormInternalName { get; set; }
        public string FormDesc { get; set; }
        public bool FormDescChangeAllowed { get; set; }
        public bool SignoffRequired { get; set; }
        public string QuoteSort { get; set; }
        public string BinderSort { get; set; }
        public string RevisionDate { get; set; }
        public DateTime? FormEffectiveDate { get; set; }
        public DateTime? FormApprovedDate { get; set; }
        public string FormApprovedId { get; set; }
        public string CreatedById { get; set; }
        public int? PageCount { get; set; }
        public int? BlankCount { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public string LastChangedId { get; set; }
        public bool? Active { get; set; }
        public string FileName { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
