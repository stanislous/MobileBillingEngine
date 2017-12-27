using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    public interface BillingEngingImp
    {
        int generateBills();
        void recordCustomerDetails(CustomerDetails cus_details);
        void recordCallDetails(CallDetailRecords cdr_details);
        int isLocalOrLongDistance(CallDetailRecords call_details);
        int isPeakOrOffPeak(DateTime start_time, int time_duration);
        int totalTax(int total_payment);
    }
}
