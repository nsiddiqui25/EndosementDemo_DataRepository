using System;
using System.Collections.Generic;

namespace DataRepository.Models.ELD.Prod1
{
    public partial class AutoBlankFillInRules
    {
        public int BlankRuleId { get; set; }
        public int? FormVersionId { get; set; }
        public int? BlankNo { get; set; }
        public string BlankValue { get; set; }
        public string ValueType { get; set; }
        public string Stage { get; set; }
        public string LastChangedId { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public bool? Active { get; set; }
        public string BusinessType { get; set; }
    }
}
