using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel.ClaimNotesViewModel
{
    public class AccountMasterViewModel
    {
        public string PolEffectiveDate { get; set; }
        public int AcctId { get; set; }
        public string PolNo { get; set; }
        public string AppNo { get; set; }
        public string Policy { get; set; }
        public string Product { get; set; }
        public string PolExpiryDate { get; set; }
        // feilds from Insured Info
        public string InsuredName { get; set; }
        public string InsuredSta { get; set; }
        public string InsuredCity { get; set; }
        // fields from Ar- Trans
        public string CurrentPremium { get; set; }
        public string CurrentLimit { get; set; }
        public string CurrentRetention { get; set; }
        public string LossRatio { get; set; }
        public int YearBound { get; set; }
        public string TotalIncurred { get; set; }
        public string TotalPremium { get; set; }
    }
}
