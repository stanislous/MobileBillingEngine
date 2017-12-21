using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileBillingEngine
{
    class CallDetailRecords : CallDetailRecordsImp
    {

        private string caller_phone_number;
        private string reciever_phone_number;
        private DateTime date_and_time;
        private int duration_in_sec;

        public void setCallDuration(int duration_in_sec)
        {
            this.duration_in_sec = duration_in_sec;
        }

        public void setCallingParty(string caller_phone_number)
        {
            this.caller_phone_number = caller_phone_number;
        }

        public void setRecievingParty(string reciever_phone_number)
        {
            this.reciever_phone_number = reciever_phone_number;
        }

        public void setStartingTime(DateTime date_and_time)
        {
            this.date_and_time = date_and_time;
        }

        public int getCallDuration()
        {
            return duration_in_sec;
        }

        public string getCallingParty()
        {
            return caller_phone_number;
        }

        public string getRecievingParty()
        {
            return reciever_phone_number;
        }

        public DateTime getStartingTime()
        {
            return date_and_time;
        }

        
    }
}
