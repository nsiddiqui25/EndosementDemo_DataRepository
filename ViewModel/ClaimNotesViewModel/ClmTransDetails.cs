using System;

namespace DataRepository.ViewModel.ClaimNotesViewModel
{
    public class ClmTransDetails
    {
       public string InsuredName { get; set; }
     //   public string ClmNo { get; set; }
       public string PolEffectiveDate { get; set; }
        public string ClmProcessDate { get; set; }
        public string PolExpirationDate { get; set; }
        //add up reserves ABC and paid ABC 
        public double TotalIncurred { get; set; }
        public double RunningIncurred { get; set; }
        public string RunIncurred { get; set; }
        public string ClmTransType { get; set; }
    }
}
