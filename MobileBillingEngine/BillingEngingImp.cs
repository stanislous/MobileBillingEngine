using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    public interface BillingEngingImp
    {
        string generateBills(CustomerDetails customer_details, CallDetailRecords cdr_sut);
    }
}
