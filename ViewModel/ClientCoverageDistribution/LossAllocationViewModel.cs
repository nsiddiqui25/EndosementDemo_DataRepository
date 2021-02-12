using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel.ClientCoverageDistribution
{
    public class LossAllocationViewModel
    {
        public int LossAllocationId { get; set; }
        public int LossAllocationItemId { get; set; }
        public decimal? AllocationValue { get; set; }
        public string ClmNo { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public string LastChangedId { get; set; }
        public string AllocationDescription { get; set; }
        public string ProductTypeCode { get; set; }
        public string CoverageTypeDescription { get; set; }
    }
}
