using System;

namespace MobileBillingEngine
{
    public class PackageB : BillingEngine
    {
        public override int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local)
        {
            time_duration -= 60;
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (start_time.Hour >= 8 && start_time.Hour < 20) // Peak Hours
                {
                    if (is_local == true) call_charge += 4;  // Peak for Local calls 
                    else call_charge += 6;  // Peak for Long Distance calls
                }
                else  // Off Peak Hours
                {
                    if (is_local == true) call_charge += 3;    // Off Peak for Local calls 
                    else call_charge += 5;    // Off Peak for Long Distance calls
                }
                start_time = start_time.AddMinutes(1);
            }
            return call_charge;
        }

        public override double costForSeconds(DateTime start_time, int time_duration, bool is_local, double seconds)
        {
            time_duration -= 60;
            DateTime end_time = start_time.AddSeconds(time_duration + seconds);
            double charge_for_seconds = 0;

            if (end_time.Hour >= 8 && end_time.Hour < 20) // Peak Hours
            {
                if (is_local == true) charge_for_seconds = (4 * seconds) / 60;
                else charge_for_seconds = (6 * seconds) / 60;
            }
            else     // Off Peak Hours
            {
                if (is_local == true) charge_for_seconds = (3 * seconds) / 60;
                else charge_for_seconds = (5 * seconds) / 60;
            }
            return charge_for_seconds;
        }

        public override int monthlyRental() { return 100; }
        
    }
}
