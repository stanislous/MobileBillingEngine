using System;
using System.Collections.Generic;

namespace MobileBillingEngine
{
    public interface BillingEngingImp
    {
        Dictionary<string,double> generateBills();

        void recordCustomerDetails(CustomerDetails cus_details);

        void recordCallDetails(CallDetailRecords cdr_details);

        int isLocalOrLongDistance(CallDetailRecords call_details);

        int isPeakForLocalCalls(DateTime start_time, int time_duration, bool its_local, bool is_per_minute);

        double totalTax(double total_payment);

        double totalDiscount(double total_payment);
    }
}
