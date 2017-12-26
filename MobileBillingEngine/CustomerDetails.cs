using System;

namespace MobileBillingEngine
{
    public class CustomerDetails
    {
        public string full_name;
        public string billing_address;
        public double phone_number;
        public int package_code;
        public DateTime registered_date;

        public CustomerDetails(string full_name, string billing_address, double phone_number, int package_code, DateTime registered_date)
        {
            this.full_name = full_name;
            this.billing_address = billing_address;
            this.phone_number = phone_number;
            this.package_code = package_code;
            this.registered_date = registered_date;
        }
        
    }
}
