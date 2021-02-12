using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel.BOR
{
    public class UndBorFind
    {
        public long? MailId { get; set; }
        public int AcctId { get; set; }
        public string PolNo { get; set; }
        public DateTime? PolEffectiveDate { get; set; }
        public string AppNo { get; set; }
        public DateTime? AppReceivedDate { get; set; }
        public int? BrokerId { get; set; }
        public int? BrokerContactId { get; set; }
        public string AcctStage { get; set; }
        public string AcctSubStage { get; set; }
        public string GeneralProduct { get; set; }
        public DateTime? TransEffectiveDate { get; set; }
        public int AcctTransId { get; set; }
        public int? Billingtypeid { get; set; }
        public int? Paymentplanid { get; set; }
        public double BrokerCommisPct { get; set; }
        public bool IsBalanced { get; set; }
        public string BrokerNo { get; set; }
        public string BrokerContactNo { get; set; }
        public decimal TotalGross { get; set; }
        public decimal TotalPdcGross { get; set; }
        public decimal BalanceNet { get; set; }

    }
}
