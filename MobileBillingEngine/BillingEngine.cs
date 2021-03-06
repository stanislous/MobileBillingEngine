﻿using System;
using System.Collections.Generic;

namespace MobileBillingEngine 
{
    public abstract class BillingEngine : BillingEngingImp
    {
        public abstract int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local);
        public abstract double costForSeconds(DateTime start_time, int time_duration, bool is_local, double seconds);

        Dictionary<double, CustomerDetails> customerDetailsMap = new Dictionary<double, CustomerDetails>();
        Dictionary<int, CallDetailRecords> callDetailsRecordMap = new Dictionary<int, CallDetailRecords>();

        static int unique_call_details = 0;

        public void recordCustomerDetails(CustomerDetails cus_details)
        {
            if (customerDetailsMap.ContainsKey(cus_details.phone_number)) { }
            else customerDetailsMap.Add(cus_details.phone_number, cus_details);
        }
        public void recordCallDetails(CallDetailRecords cdr_details)
        {
            callDetailsRecordMap.Add(unique_call_details, cdr_details);
            unique_call_details++;
        }

        public object packageHandler(string package_name)
        {
            if (package_name == "package A") return new PackageA();
            else if (package_name == "package B") return new PackageB();
            else if (package_name == "package C") return new PackageC();
            else return new PackageD();
        }

        public Dictionary<string, double> generateBills()
        {
            double total_payment = 0;
            double tax = 0;
            double discount = 0;
            Dictionary<string, double> bill_set = new Dictionary<string, double>();
            BillingEngine reference;

            foreach (var customer in customerDetailsMap)
            {
                reference = (BillingEngine)packageHandler(customer.Value.package_name);

                foreach (var record in callDetailsRecordMap)
                {
                    if (customer.Value.phone_number == record.Value.getCallingParty()/* && customer.Value.package_name == record.Value.getPackage()*/)
                    {
                        total_payment += reference.isLocalOrLongDistance(record.Value);
                        tax = totalTax(total_payment + reference.monthlyRental());
                        if(total_payment > 1000) discount = reference.totalDiscount(total_payment);
                        total_payment += tax + reference.monthlyRental() - discount;
                    }
                }
                bill_set.Add("0"+ customer.Value.phone_number.ToString(), total_payment);
                BillInformation bill_info = new BillInformation(customer.Value.full_name, customer.Value.phone_number, customer.Value.billing_address, total_payment-tax-discount-reference.monthlyRental(), discount, tax, reference.monthlyRental(), total_payment);
                total_payment = 0;
            }
            return bill_set;
        }

        public double isLocalOrLongDistance(CallDetailRecords call_details)
        {
            double originate_number = call_details.getCallingParty();
            double recieve_number = call_details.getRecievingParty();

            double payment = 0;
            bool is_local = true;
            double seconds = call_details.getSeconds();

            int time_duration = call_details.getCallDuration();

            if ((int)originate_number / 10000000 == (int)recieve_number / 10000000) //local call
            {
                payment += isPeakForLocalCalls(call_details.getStartingTime(), time_duration, is_local) + 
                    costForSeconds(call_details.getStartingTime(), time_duration, is_local, seconds);
            }
            else   //long distance call
            {
                payment += isPeakForLocalCalls(call_details.getStartingTime(), time_duration, false) +
                    costForSeconds(call_details.getStartingTime(), time_duration, false, seconds);
            }
            return payment;
        }

        /* public double isLocalOrLongDistance(CallDetailRecords call_details)
         {
             double originate_number = call_details.getCallingParty();
             double recieve_number = call_details.getRecievingParty();

             double payment = 0;
             bool is_local = true;
             bool is_per_minute = false;
             int time_duration = call_details.getCallDuration();
             double seconds = 0;

             if (call_details.getBillingType() == "per minute") is_per_minute = true;
             if (call_details.getBillingType() == "per second" && call_details.getSeconds() != 0)
             {
                 is_per_minute = false;
                 time_duration -= 60;
                 seconds = call_details.getSeconds();
             }

             if ((int)originate_number / 10000000 == (int)recieve_number / 10000000) //local call
             {
                 payment += isPeakForLocalCalls(call_details.getStartingTime(), time_duration, is_local, is_per_minute) + 
                     costForSeconds(call_details.getStartingTime(), time_duration, is_local, seconds);
             }
             else   //long distance call
             {
                 is_local = false;
                 payment += isPeakForLocalCalls(call_details.getStartingTime(), time_duration, is_local, is_per_minute) +
                     costForSeconds(call_details.getStartingTime(), time_duration, is_local, seconds);
             }
             return payment;
         }*/
        /* public int isPeakForLocalCalls(DateTime start_time, int time_duration, bool is_local, bool is_per_minute)
         {
             DateTime end_time = start_time.AddSeconds(time_duration);
             int call_charge = 0;

             while (start_time != end_time)
             {
                 if (start_time.Hour >= 8 && start_time.Hour < 20) // Peak Hours
                 {
                     if (is_local == true && is_per_minute == true) call_charge += 3;  //Per Minute Peak for Local calls 
                     else if (is_local == false && is_per_minute == true) call_charge += 5;  //Per Minute Peak for Long Distance calls
                     else if (is_local == true && is_per_minute == false) call_charge += 4;  //Per Second Peak for Local calls
                     else call_charge += 6;  //Per second Peak for Long Distance calls
                 }
                 else  // Off Peak Hours
                 {
                     if (is_local == true && is_per_minute == true) call_charge += 2;    //Per Minute Off Peak for Local calls
                     else if (is_local == false && is_per_minute == true) call_charge += 4;    //Per Minute Off Peak for Long Distance calls
                     else if (is_local == true && is_per_minute == false) call_charge += 3;    //Per second Off Peak for Local calls
                     else call_charge += 5;    //Per second Off Peak for Long Distance calls
                 }
                 start_time = start_time.AddMinutes(1);
             }
             return call_charge;
         }*/


        public bool isPeakHours(int start_hour, int end_hour)
        {
            if (start_hour >= 8 && end_hour < 20)
                return true;
            else return false;
        }

        public abstract int monthlyRental();
        public double totalTax(double total_payment) { return total_payment/5; } //20% tax
        public abstract double totalDiscount(double total_payment);//0% discount       
    }
}
