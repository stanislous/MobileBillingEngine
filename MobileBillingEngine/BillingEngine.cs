using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine 
{
    public class BillingEngine : BillingEngingImp
    {

        Dictionary<string, CustomerDetails> customerDetailsMap = new Dictionary<string, CustomerDetails>();
        Dictionary<string, CallDetailRecords> callDetailsRecordMap = new Dictionary<string, CallDetailRecords>();

        public string generateBills(CustomerDetails customer_details, CallDetailRecords cd_record)
        {

            

            

            return "fv";
        }
    }
}
