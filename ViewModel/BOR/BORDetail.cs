using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel.BOR
{
    public class BORDetail
    {

        //Acct_trans
        public int AcctId { get; set; }
        public string PolNo { get; set; }
        public DateTime? PolEffectiveDate { get; set; }
        public DateTime? PolExpirationDate { get; set; }
        public int? BrokerId { get; set; }
        public int? BrokerContactId { get; set; }

        //lkp_submission_status
        public string GenStat { get; set; }
       
        //broker contact
        public string BrokerNo { get; set; }
        public string BrokerContactNo { get; set; }
        public string BrokerEmail { get; set; }
        public string BrokerFirstName { get; set; }
        public string BrokerLastName { get; set; }
        public string BrokerTel { get; set; }
        


        //broker master
        public string BrokerCity { get; set; }
        public string BrokerSta { get; set; }
        public double CommissionPct { get; set; }


    }
}
