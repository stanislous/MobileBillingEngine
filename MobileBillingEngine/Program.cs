using System;

namespace MobileBillingEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            BillingEngine bengine_sut = new BillingEngine();

            CallDetailRecords cdr_sut_1;
            CallDetailRecords cdr_sut_2;
            CallDetailRecords cdr_sut_3;
            CallDetailRecords cdr_sut_4;
            CallDetailRecords cdr_sut_5;
            CallDetailRecords cdr_sut_6;
            CallDetailRecords cdr_sut_7;
            CallDetailRecords cdr_sut_8;
            CallDetailRecords cdr_sut_9;
            CallDetailRecords cdr_sut_10;
            CallDetailRecords cdr_sut_11;

            CustomerDetails cusdetails_sut_1;
            CustomerDetails cusdetails_sut_2;
            CustomerDetails cusdetails_sut_3;
            CustomerDetails cusdetails_sut_4;
            CustomerDetails cusdetails_sut_5;
            CustomerDetails cusdetails_sut_6;
            CustomerDetails cusdetails_sut_7;
            CustomerDetails cusdetails_sut_8;
            CustomerDetails cusdetails_sut_9;
            CustomerDetails cusdetails_sut_10;

            cdr_sut_1 = new CallDetailRecords();
            //cdr for 1
            cdr_sut_1.setCallingParty(0713082022);
            cdr_sut_1.setRecievingParty(0333334184);
            cdr_sut_1.setStartingTime(new DateTime(2017, 3, 23, 10, 34, 0));
            cdr_sut_1.setCallDuration(120);

            cdr_sut_2 = new CallDetailRecords();
            //cdr for 2
            cdr_sut_2.setCallingParty(0723082022);
            cdr_sut_2.setRecievingParty(0334334184);
            cdr_sut_2.setStartingTime(new DateTime(2017, 3, 23, 12, 34, 0));
            cdr_sut_2.setCallDuration(120);

            cdr_sut_3 = new CallDetailRecords();
            //cdr for 3
            cdr_sut_3.setCallingParty(0723082022);
            cdr_sut_3.setRecievingParty(0332334184);
            cdr_sut_3.setStartingTime(new DateTime(2017, 3, 23, 16, 34, 0));
            cdr_sut_3.setCallDuration(120);

            cdr_sut_4 = new CallDetailRecords();
            //cdr for 4
            cdr_sut_4.setCallingParty(0733082022);
            cdr_sut_4.setRecievingParty(0331334184);
            cdr_sut_4.setStartingTime(new DateTime(2017, 3, 23, 20, 34, 0));
            cdr_sut_4.setCallDuration(120);

            cdr_sut_5 = new CallDetailRecords();
            //cdr for 5
            cdr_sut_5.setCallingParty(0743082022);
            cdr_sut_5.setRecievingParty(0331334184);
            cdr_sut_5.setStartingTime(new DateTime(2017, 3, 23, 3, 34, 0));
            cdr_sut_5.setCallDuration(120);

            cdr_sut_6 = new CallDetailRecords();
            //cdr for 6
            cdr_sut_6.setCallingParty(0753082022);
            cdr_sut_6.setRecievingParty(0332334184);
            cdr_sut_6.setStartingTime(new DateTime(2017, 3, 23, 7, 34, 0));
            cdr_sut_6.setCallDuration(120);

            cdr_sut_7 = new CallDetailRecords();
            //cdr for 7
            cdr_sut_7.setCallingParty(0763082022);
            cdr_sut_7.setRecievingParty(0331334184);
            cdr_sut_7.setStartingTime(new DateTime(2017, 3, 23, 9, 34, 0));
            cdr_sut_7.setCallDuration(120);

            cdr_sut_8 = new CallDetailRecords();
            //cdr for 8
            cdr_sut_8.setCallingParty(0703082022);
            cdr_sut_8.setRecievingParty(0703082029);
            cdr_sut_8.setStartingTime(new DateTime(2017, 3, 23, 19, 50, 0));
            cdr_sut_8.setCallDuration(20 * 60);

            cdr_sut_9 = new CallDetailRecords();
            //cdr for 9
            cdr_sut_9.setCallingParty(0603082022);
            cdr_sut_9.setRecievingParty(0603082021);
            cdr_sut_9.setStartingTime(new DateTime(2017, 3, 23, 7, 50, 0));
            cdr_sut_9.setCallDuration(20 * 60);

            cdr_sut_10 = new CallDetailRecords();
            //cdr for 10
            cdr_sut_10.setCallingParty(0613082022);
            cdr_sut_10.setRecievingParty(0333334184);
            cdr_sut_10.setStartingTime(new DateTime(2017, 3, 23, 19, 50, 0));
            cdr_sut_10.setCallDuration(20 * 60);

            cdr_sut_11 = new CallDetailRecords();
            //cdr for 11
            cdr_sut_11.setCallingParty(0623082022);
            cdr_sut_11.setRecievingParty(0333334184);
            cdr_sut_11.setStartingTime(new DateTime(2017, 3, 23, 7, 50, 0));
            cdr_sut_11.setCallDuration(20 * 60);

            cusdetails_sut_1 = new CustomerDetails("Shehan Erange", "Shehan Address", 0713082022, 1, new DateTime(2015, 3, 22, 15, 0, 0));
            cusdetails_sut_2 = new CustomerDetails("Menuka Nayanadipa", "Menuka Address", 0723082022, 2, new DateTime(2015, 3, 22, 6, 30, 0));
            cusdetails_sut_3 = new CustomerDetails("Sachini Perera", "sachini Address", 0733082022, 3, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_4 = new CustomerDetails("Anuththara Perera", "Anuththara Address", 0743082022, 4, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_5 = new CustomerDetails("Oshiini Perera", "Oshini Address", 0753082022, 5, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_6 = new CustomerDetails("Sanduni Perera", "Sanduni Address", 0763082022, 6, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_7 = new CustomerDetails("Naduni Perera", "Naduni Address", 0703082022, 7, new DateTime(2015, 2, 12, 4, 7, 0));
            cusdetails_sut_8 = new CustomerDetails("Hashini Perera", "Hashini Address", 0603082022, 8, new DateTime(2015, 2, 12, 4, 7, 0));
            cusdetails_sut_9 = new CustomerDetails("Waruni Perera", "Waruni Address", 0613082022, 9, new DateTime(2015, 2, 12, 9, 7, 0));
            cusdetails_sut_10 = new CustomerDetails("Waruni Perera", "Waruni Address", 0623082022, 9, new DateTime(2015, 2, 12, 9, 7, 0));

            bengine_sut.recordCustomerDetails(cusdetails_sut_1);
            bengine_sut.recordCustomerDetails(cusdetails_sut_2);
            bengine_sut.recordCustomerDetails(cusdetails_sut_3);
            bengine_sut.recordCustomerDetails(cusdetails_sut_4);
            bengine_sut.recordCustomerDetails(cusdetails_sut_5);
            bengine_sut.recordCustomerDetails(cusdetails_sut_6);
            bengine_sut.recordCustomerDetails(cusdetails_sut_7);
            bengine_sut.recordCustomerDetails(cusdetails_sut_8);
            bengine_sut.recordCustomerDetails(cusdetails_sut_9);
            bengine_sut.recordCustomerDetails(cusdetails_sut_10);
            bengine_sut.recordCallDetails(cdr_sut_1);
            bengine_sut.recordCallDetails(cdr_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_3);
            bengine_sut.recordCallDetails(cdr_sut_4);
            bengine_sut.recordCallDetails(cdr_sut_5);
            bengine_sut.recordCallDetails(cdr_sut_6);
            bengine_sut.recordCallDetails(cdr_sut_7);
            bengine_sut.recordCallDetails(cdr_sut_8);
            bengine_sut.recordCallDetails(cdr_sut_9);
            bengine_sut.recordCallDetails(cdr_sut_10);
            bengine_sut.recordCallDetails(cdr_sut_11);

            Console.WriteLine(bengine_sut.generateBills());
            Console.ReadKey();
        }
    }
}
