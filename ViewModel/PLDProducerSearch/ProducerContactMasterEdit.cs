using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel.PLDProducerSearch
{
   public class ProducerContactMasterEdit
    {
        public int BrokerContactID { get; set; }
        public string BrokerNo { get; set; }
        public string BrokerContactNo { get; set; }
        public string BrokerFirstName { get; set; }
        public string BrokerLastName { get; set; }
        public string BrokerEmail { get; set; }
        public string BrokerTel { get; set; }
        public string ProducerState { get; set; }
        public string ProducerCity { get; set; }
        public string MasterContactType { get; set; }
        public string ProducerName { get; set; }
        public string BrokerFax { get; set; }
        public string BrokerTitle { get; set; }
        public string BrokerContactSalesForceLinkID { get; set; }
        public int BrokerId { get; set; }
        public bool? Unsubscribe { get; set; }
        public bool? Bremoved { get; set; }
    }
}
