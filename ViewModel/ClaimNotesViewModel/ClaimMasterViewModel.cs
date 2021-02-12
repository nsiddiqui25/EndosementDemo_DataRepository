using System;

namespace DataRepository.ViewModel
{
   public class ClaimMasterViewModel
    {
        // fields from claim Master
        public string ClmNo { get; set; }
        public string ClmCreatedDate { get; set; }
        public string ClmMadeDate { get; set; }
        public string PaidA { get; set; }
        public string PaidB { get; set; }
        public string PaidC { get; set; }
        public string Attorney { get; set; }
        public string RenewalComments { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }

        //// fields from Account Master
        public string PolNo { get; set; }
        //public string Policy { get; set; }
        //public string Product { get; set; }
        //public string PolEffectiveDate { get; set; }

        //// fields from Ar- Trans
        //public string CurrentPremium { get; set; }
        //public double CurrentLimit { get; set; }
        //public string CurrentRetention { get; set; }
        //public string LossRatio { get; set; }

        //// feilds from Insured Info
        //public string InsuredName { get; set; }
        //public string InsuredSta { get; set; }
        //public string InsuredCity { get; set; }

        //public int? YearBound { get; set; }
        //public string TotalIncurred { get; set; }
        //public string TotalPremium { get; set; }
        public string AcctId { get; set; }

        public string OutstandingReserve { get; set; }
    }
}
