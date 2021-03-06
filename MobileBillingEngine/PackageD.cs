﻿using System;

namespace MobileBillingEngine
{
    public class PackageD : BillingEngine
    {
        public override int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local)
        {
            time_duration -= 60;
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (isPeakHours(start_time.Hour, start_time.Hour)) // Peak Hours
                {
                    if (is_local == true) call_charge += 3;  // Peak for Local calls 
                    else call_charge += 5;  // Peak for Long Distance calls
                }
                else  // Off Peak Hours
                {
                    if (is_local == true) call_charge += 2;    // Off Peak for Local calls 
                    else call_charge += 4;    // Off Peak for Long Distance calls
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

            if (isPeakHours(start_time.Hour, start_time.Hour)) // Peak Hours
            {
                if (is_local) charge_for_seconds = (3 * seconds) / 60;
                else charge_for_seconds = (5 * seconds) / 60;
            }
            else     // Off Peak Hours
            {
                if (is_local) charge_for_seconds = (2 * seconds) / 60;
                else charge_for_seconds = (4 * seconds) / 60;
            }
            return charge_for_seconds;
        }

        public override int monthlyRental() { return 300; }
        public override double totalDiscount(double total_payment) { return 0; }
    }
}
