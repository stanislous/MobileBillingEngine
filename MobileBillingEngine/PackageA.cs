using System;

namespace MobileBillingEngine
{
    class PackageA : BillingEngine
    {
        public override double isLocalOrLongDistance(CallDetailRecords call_details)
        {
            double originate_number = call_details.getCallingParty();
            double recieve_number = call_details.getRecievingParty();

            double payment = 0;
            bool is_local = true;
            
            int time_duration = call_details.getCallDuration();
             
            if ((int)originate_number / 10000000 == (int)recieve_number / 10000000) //local call
            {
                payment += isPeakForLocalCalls(call_details.getStartingTime(), time_duration, is_local);                 
            }
            else   //long distance call
            {
                payment += isPeakForLocalCalls(call_details.getStartingTime(), time_duration, is_local);                
            }
            return payment;
        }

        public override int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local)
        {
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (start_time.Hour >= 8 && start_time.Hour < 20) // Peak Hours
                {
                    if (is_local == true) call_charge += 3;  // Peak for Local calls 
                    else call_charge += 5;  // Peak for Long Distance calls
                }
                else  // Off Peak Hours
                {
                    if (is_local == true ) call_charge += 2;    // Off Peak for Local calls
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
    }
}
