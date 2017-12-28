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
                        tax = totalTax(total_payment);
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

            if ((int)originate_number / 10000000 == (int)recieve_number / 10000000) //local call
            {
                payment += isPeakForLocalCalls(call_details.getStartingTime(), call_details.getCallDuration());
            }
            else   //long distance call
            {
                payment += isPeakForLongDistanceCalls(call_details.getStartingTime(), call_details.getCallDuration());
            }
            return payment;
        }

        public int isPeakForLocalCalls(DateTime start_time, int time_duration)
        {
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (start_time.Hour >= 8 && start_time.Hour < 20)
                {
                    call_charge += 3;  //Peak for Local calls
                }
                else
                {
                    call_charge += 2;    //Off Peak for Local calls
                }
                start_time = start_time.AddMinutes(1);
            }
            return call_charge;
        }

        public int isPeakForLongDistanceCalls(DateTime start_time, int time_duration)
        {
            DateTime end_time = start_time.AddSeconds(time_duration);
            int call_charge = 0;

            while (start_time != end_time)
            {
                if (start_time.Hour >= 8 && start_time.Hour < 20)
                {
                    call_charge += 5;  //Peak for Long Distance calls
                }
                else
                {
                    call_charge += 4;    //Off Peak for Long Distance calls
                }
                start_time = start_time.AddMinutes(1);
            }
            return call_charge;
        }

        public double totalTax(double total_payment)
        {
            return total_payment/5;    //20% tax
        }  

        public double totalDiscount(double total_payment)
        {
            return /*total_payment / 20*/0; //5% discount
        }
    }
}
