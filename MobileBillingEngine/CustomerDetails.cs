using System;

namespace MobileBillingEngine
{
    public class CustomerDetails
    {
        string full_name;
        string billing_address;
        string phone_number;
        int package_code;
        DateTime registered_date;

        CustomerDetails(string full_name, string billing_address, string phone_number, int package_code, DateTime registered_date)
        {
            this.full_name = full_name;
            this.billing_address = billing_address;
            this.phone_number = phone_number;
            this.package_code = package_code;
            this.registered_date = registered_date;
        }
    }
}
