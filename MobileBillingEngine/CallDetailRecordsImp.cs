using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    public interface CallDetailRecordsImp
    {
        void setCallingParty(string caller_phone_number);
        string getCallingParty();
        
        void setRecievingParty(string reciever_phone_number);
        string getRecievingParty();

        void setStartingTime(DateTime date_and_time);
        DateTime getStartingTime();

        void setCallDuration(int duration_in_sec);
        int getCallDuration();
    }
}
