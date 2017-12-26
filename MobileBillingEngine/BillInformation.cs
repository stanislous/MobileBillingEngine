using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    public class BillInformation
    {
         string customer_name;
         double phone_number;
         string billing_address;
         int total_call_charge;
         int total_discount;
         int tax;
         int rental;
         int bill_amount;

        public BillInformation(string customer_name, double phone_number, string billing_address, int total_call_charge, int total_discount, int tax, int rental, int bill_amount)
        {
            this.customer_name = customer_name;
            this.phone_number = phone_number;
            this.billing_address = billing_address;
            this.total_call_charge = total_call_charge;
            this.total_discount = total_discount;
            this.tax = tax;
            this.rental = rental;
            this.bill_amount = bill_amount;
        }
        public override string ToString()
        {
            return String.Format("{0}  0{1}", customer_name, phone_number);
        }

        /*  public string Customer_name
          {
              get { return customer_name; } set { customer_name = value; }
          }

          public string Phone_number
          {
              get { return phone_number; } set { phone_number = value; }
          }

          public string Billing_adress
          {
              get {return billing_adress;} set { billing_adress = value; }
          }

          public int Total_call_charge
          {
              get { return total_call_charge;} set { total_call_charge = value; }
          }

          public int Total_discount
          {
              get { return total_discount; } set { total_discount = value; }
          }

          public int Tax
          {
              get { return tax; }  set { tax = value; }
          }

          public int Rental
          {
              get { return rental; } set {rental = value; }
          }

          public int Bill_amount
          {
              get { return bill_amount; } set { bill_amount = value; }
          }*/
    }
}
