using System;

namespace MobileBillingEngine
{
    public class PackageA : BillingEngine
    {       
        public override int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local)
        {
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (start_time.Hour >= 10 && start_time.Hour < 18) // Peak Hours
                {
                    if (is_local) call_charge += 3;  // Peak for Local calls 
                    else call_charge += 5;  // Peak for Long Distance calls
                }
                else  // Off Peak Hours
                {
                    if (is_local) call_charge += 2;    // Off Peak for Local calls
                    else call_charge += 4;    // Off Peak for Long Distance calls
                }
                start_time = start_time.AddMinutes(1);
            }
            return call_charge;
        }
        public override double costForSeconds(DateTime start_time, int time_duration, bool is_local, double seconds)
        {
            return 0;
        }
        public override int monthlyRental() { return 100; }
        public override double totalDiscount(double total_payment) { return total_payment/2.5; }
    }
}
