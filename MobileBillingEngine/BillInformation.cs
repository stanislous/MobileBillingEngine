using System;

namespace MobileBillingEngine
{
    public class BillInformation
    {
         string customer_name;
         double phone_number;
         string billing_address;
         double total_call_charge;
         double total_discount;
         double tax;
         double rental;
         double bill_amount;

        public BillInformation(string customer_name, double phone_number, string billing_address, double total_call_charge, double total_discount, double tax, double rental, double bill_amount)
        {
            this.customer_name = customer_name;
            this.phone_number = phone_number;
            this.billing_address = billing_address;
            this.total_call_charge = total_call_charge;
            this.total_discount = total_discount;
            this.tax = tax;
            this.rental = rental;
            this.bill_amount = bill_amount;

            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return String.Format(" Customer Name: {0} \n Phone Number: 0{1} \n Billing Address:{2} \n Totoal Call Charge: {3} \n Total Discount: {4} \n Tax: {5} \n Rental: {6} \n Bill Amount: {7} \n", customer_name, phone_number, billing_address, total_call_charge, total_discount, tax, rental, bill_amount);
        }
    }
}