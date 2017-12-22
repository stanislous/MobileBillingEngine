using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    public class BillInformation
    {
        private string customer_name;
        private string phone_number;
        private string billing_adress;
        private int total_call_charge;
        private int total_discount;
        private int tax;
        private int rental;
        private int bill_amount;

        public string Customer_name
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
        }
    }
}
