using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    public interface CallDetailRecordsImp
    {
        void setCallingParty(double caller_phone_number);
        double getCallingParty();
        
        void setRecievingParty(double reciever_phone_number);
        double getRecievingParty();

        void setStartingTime(DateTime date_and_time);
        DateTime getStartingTime();

        void setCallDuration(int duration_in_sec);
        int getCallDuration();
       
    }
}
