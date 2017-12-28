﻿using System;

namespace MobileBillingEngine
{
    public class CallDetailRecords
    {
        private double caller_phone_number;
        private double reciever_phone_number;
        private DateTime date_and_time;
        private int duration_in_sec;

        public void setCallDuration(int duration_in_sec)
        {
            if (duration_in_sec < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(duration_in_sec), "Time must be a positive number.");
            }
            else
            {
                if (duration_in_sec % 60 > 0)
                {
                    duration_in_sec += 60 - (duration_in_sec % 60);
                }
                this. duration_in_sec = duration_in_sec;
            }
        }

        public void setCallingParty(double caller_phone_number)
        {
            if (caller_phone_number < 0 || caller_phone_number.ToString().Length > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(caller_phone_number), "Invalid Number.");
            }
            else  this.caller_phone_number = caller_phone_number;  
        }

        public void setRecievingParty(double reciever_phone_number)
        {
            if (reciever_phone_number < 0 )
            {
                throw new ArgumentOutOfRangeException(nameof(reciever_phone_number), "Invalid Number.");
            }
            else  this.reciever_phone_number = reciever_phone_number;   
        }

        public void setStartingTime(DateTime date_and_time)
        {
            this.date_and_time = date_and_time;
        }

        public int getCallDuration()
        {
            return duration_in_sec;
        }

        public double getCallingParty()
        {
            return caller_phone_number;
        }

        public double getRecievingParty()
        {
            return reciever_phone_number;
        }

        public DateTime getStartingTime()
        {
            return date_and_time;
        }

    
        
    }
}
