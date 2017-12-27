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
        Dictionary<int, CallDetailRecords> callDetailsRecordMap = new Dictionary<int, CallDetailRecords>();

        static int unique_customer = 0;
        static int unique_call_details = 0;

        public void recordCustomerDetails(CustomerDetails cus_details)
        {
            customerDetailsMap.Add(unique_customer, cus_details);
            unique_customer++;
        }
        public void recordCallDetails(CallDetailRecords cdr_details)
        {
            callDetailsRecordMap.Add(unique_call_details, cdr_details);
            unique_call_details++;
        }

        public int generateBills()
        {
            int total_payment = 0;
            int tax = 0;

            foreach (var customer in customerDetailsMap)
            {
                foreach (var record in callDetailsRecordMap)
                {
                    if (customer.Value.phone_number == record.Value.getCallingParty())
                    {
                        total_payment += isLocalOrLongDistance(record.Value);
                        tax = totalTax(total_payment);   
                    }

                }
               // BillInformation bill_info = new BillInformation(customer.Value.full_name, customer.Value.phone_number, customer.Value.billing_address, total_payment, 25, 50, 75, 23);
            }
            return total_payment;
        }

        public int isLocalOrLongDistance(CallDetailRecords call_details)
        {

            double originate_number = call_details.getCallingParty();
            double recieve_number = call_details.getRecievingParty();

            int payment = 0;

            if ((int)originate_number / 10000000 == (int)recieve_number / 10000000) //local call
            {
                payment = 3;
                payment += isPeakOrOffPeak(call_details.getStartingTime(), call_details.getCallDuration());
            }
            else   //long distance call
            {
                payment = 5;
                payment += isPeakOrOffPeak(call_details.getStartingTime(), call_details.getCallDuration());
            }
            return payment;
        }

        public int isPeakOrOffPeak(DateTime start_time, int time_duration)
        {
            int payment = 0;

            DateTime end_time = start_time.AddSeconds(time_duration);
            
            if (start_time.Hour >= 8 && end_time.Hour < 20) //Peak hours
            {
                payment = 2;
               
            }
            else if (start_time.Hour >= 0 && end_time.Hour < 8 || start_time.Hour >= 20 && end_time.Hour <= 24) //Off Peak Hours
            {
                payment = 3;
            }
            //else if ()
            // {
            //  }
            return payment;
        }

        public int totalTax(int total_payment)
        {
            return total_payment/5;
        }
    }
}
