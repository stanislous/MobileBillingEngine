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

        Dictionary<int, CustomerDetails> customerDetailsMap = new Dictionary<int, CustomerDetails>();
        Dictionary<int, CallDetailRecordsImp> callDetailsRecordMap = new Dictionary<int, CallDetailRecordsImp>();

        static int unique_customer = 0;
        static int unique_call_details = 0;

        public void recordCustomerDetails(CustomerDetails cus_details)
        {
            customerDetailsMap.Add(unique_customer, cus_details);
            unique_customer++;
        }
        public void recordCallDetails(CallDetailRecordsImp cdr_details)
        {
            callDetailsRecordMap.Add(unique_call_details, cdr_details);
            unique_call_details++;
        }

        public int generateBills()
        {
            int i = 0;
            foreach (var customer in customerDetailsMap)
            {
                foreach (var record in callDetailsRecordMap)
                {
                    if (customer.Value.phone_number == record.Value.getCallingParty())
                    {
                        i++;
                    }
                }
            }
            return i;
        }

        public void isLocalOrLongDistance()
        {
            
        }

        public void isPeakOrOffPeak()
        {

        }
    }
}
