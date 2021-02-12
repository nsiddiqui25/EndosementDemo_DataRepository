using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel
{
  public  class BrokerContactMaster
    {
        public int BrokerContactID { get; set; }
        public string MasterBrokerNo { get; set; }
        public int BrokerConatctContactId { get; set; }
        public string BrokerContactFirstName { get; set; }    
        public string BrokerContactLastName {get; set;}
        public string BrokerContactEmail { get; set; }
        public string BrokerContactPhone { get; set; }
        public string MasterContactState { get; set; }
        public string MasterContactCity { get; set; }
        public string MasterContactType { get; set; }
        public string BrokerName { get; set; }

    }
}
