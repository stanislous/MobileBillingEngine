using System;
using System.Collections.Generic;

namespace MobileBillingEngine 
{
    public class BillingEngine : BillingEngingImp
    {
        Dictionary<double, CustomerDetails> customerDetailsMap = new Dictionary<double, CustomerDetails>();
        Dictionary<int, CallDetailRecords> callDetailsRecordMap = new Dictionary<int, CallDetailRecords>();

        //static int unique_customer = 0;
        static int unique_call_details = 0;

        public void recordCustomerDetails(CustomerDetails cus_details)
        {
            if (customerDetailsMap.ContainsKey(cus_details.phone_number));
            else customerDetailsMap.Add(cus_details.phone_number, cus_details);
        }
        public void recordCallDetails(CallDetailRecords cdr_details)
        {
            callDetailsRecordMap.Add(unique_call_details, cdr_details);
            unique_call_details++;
        }

        public Dictionary<string, double> generateBills()
        {
            double total_payment = 0;
            double tax = 0;
            double discount = 0;
            Dictionary<string, double> bill_set = new Dictionary<string, double>();

            foreach (var customer in customerDetailsMap)
            {
                foreach (var record in callDetailsRecordMap)
                {
                    if (customer.Value.phone_number == record.Value.getCallingParty())
                    {
                        total_payment += isLocalOrLongDistance(record.Value);
                        tax = totalTax(total_payment+100);
                        discount = totalDiscount(total_payment);
                        total_payment += tax + discount + 100;
                    }
                }
                bill_set.Add("0"+ customer.Value.phone_number.ToString(), total_payment);
                BillInformation bill_info = new BillInformation(customer.Value.full_name, customer.Value.phone_number, customer.Value.billing_address, total_payment-tax-discount-100, discount, tax, 100, total_payment);
                total_payment = 0;
            }
            return bill_set;
        }

        public int isLocalOrLongDistance(CallDetailRecords call_details)
        {
            double originate_number = call_details.getCallingParty();
            double recieve_number = call_details.getRecievingParty();

            int payment = 0;
            bool is_local = true;
            bool is_per_minute;

            if (call_details.getBillingType() == "per minute") is_per_minute = true;
            else is_per_minute = false;

            if ((int)originate_number / 10000000 == (int)recieve_number / 10000000) //local call
            {
                payment += isPeakForLocalCalls(call_details.getStartingTime(), call_details.getCallDuration(), is_local, is_per_minute);
            }
            else   //long distance call
            {
                is_local = false;
                payment += isPeakForLocalCalls(call_details.getStartingTime(), call_details.getCallDuration(), is_local, is_per_minute);
            }
            return payment;
        }

        public int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local, bool is_per_minute)
        {
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (start_time.Hour >= 8 && start_time.Hour < 20)
                {
                    if (is_local == true && is_per_minute == true) call_charge += 3;  //Per Minute Peak for Local calls 
                    else if (is_local == false && is_per_minute == true) call_charge += 5;  //Per Minute Peak for Long Distance calls
                    else if (is_local == true && is_per_minute == false) call_charge += 4;  //Per Second Peak for Local calls
                    else call_charge += 6;  //Per second Peak for Long Distance calls
                }
                else
                {
                    if (is_local == true && is_per_minute == true) call_charge += 2;    //Per Minute Off Peak for Local calls
                    else if (is_local == false && is_per_minute == true) call_charge += 4;    //Per Minute Off Peak for Long Distance calls
                    else if (is_local == true && is_per_minute == false) call_charge += 3;    //Per second Off Peak for Local calls
                    else call_charge += 5;    //Per second Off Peak for Long Distance calls
                }
                start_time = start_time.AddMinutes(1);
            }
            return call_charge;
        }

        public double totalTax(double total_payment) { return total_payment/5; } //20% tax

        public double totalDiscount(double total_payment) { return /*total_payment / 20*/0; }//0% discount       
    }
}
