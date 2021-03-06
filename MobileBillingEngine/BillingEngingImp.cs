﻿using System;
using System.Collections.Generic;

namespace MobileBillingEngine
{
    public interface BillingEngingImp
    {
        Dictionary<string,double> generateBills();

        void recordCustomerDetails(CustomerDetails cus_details);

        void recordCallDetails(CallDetailRecords cdr_details);

        double isLocalOrLongDistance(CallDetailRecords call_details);

        int isPeakForLocalCalls(DateTime start_time, int time_duration, bool its_local);

        double totalTax(double total_payment);

        double totalDiscount(double total_payment);

        double costForSeconds(DateTime start_time, int time_duration, bool is_local, double seconds);
    }
}
