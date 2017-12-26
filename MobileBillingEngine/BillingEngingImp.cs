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
        int generateBills();
        void recordCustomerDetails(CustomerDetails cus_details);
        void recordCallDetails(CallDetailRecordsImp cdr_details);
    }
}
