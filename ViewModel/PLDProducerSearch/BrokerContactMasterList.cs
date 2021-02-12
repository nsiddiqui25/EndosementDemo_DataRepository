using System;
using System.Collections.Generic;
using System.Text;

namespace DataRepository.ViewModel.PLDProducerSearch
{
   public class BrokerContactMasterList
    {
        
        public IEnumerable<BrokerContactMaster> BrokerContacts { get; set; }
        public int BrokerMasterLength { get; set; }
    }
    public class BrokerMasterList
    {

        public IEnumerable<BrokerMasterHouseNo> BrokerMasters { get; set; }
        public int BrokerMasterLength { get; set; }
    }

}
