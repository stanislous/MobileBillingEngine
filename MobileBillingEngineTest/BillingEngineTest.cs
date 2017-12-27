using NUnit.Framework;
using MobileBillingEngine;
using System;

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class BillingEngineTest
    {
        private CallDetailRecords cdr_sut_1;
        private CallDetailRecords cdr_sut_2;
        private CallDetailRecords cdr_sut_3;
        private CallDetailRecords cdr_sut_4;
        private CallDetailRecords cdr_sut_5;
        private CallDetailRecords cdr_sut_6;
        private CallDetailRecords cdr_sut_7;

        private CustomerDetails cusdetails_sut_1;
        private CustomerDetails cusdetails_sut_2;
        private CustomerDetails cusdetails_sut_3;
        private CustomerDetails cusdetails_sut_4;
        private CustomerDetails cusdetails_sut_5;
        private CustomerDetails cusdetails_sut_6;
        private CustomerDetails cusdetails_sut_7;

        private BillingEngingImp bengine_sut;
        private BillInformation binfo_sut;
        

        [SetUp]
        public void Setup()
        {
            bengine_sut = new BillingEngine();

            ///////////////////////////Call Record Details//////////////////////////////

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

            ///////////////////////////////Customer Details////////////////////////////////

            cusdetails_sut_1 = new CustomerDetails("Shehan Erange", "Shehan Address", 0713082022, 377, new DateTime(2015, 3, 22, 15, 0, 0));
            cusdetails_sut_2 = new CustomerDetails("Menuka Nayanadipa", "Menuka Address", 0723082022, 454, new DateTime(2015, 3, 22, 6, 30, 0));
            cusdetails_sut_3 = new CustomerDetails("Sachini Perera", "sachini Address", 0733082022, 235, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_4 = new CustomerDetails("Anuththara Perera", "Anuththara Address", 0743082022, 235, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_5 = new CustomerDetails("Oshiini Perera", "Oshini Address", 0753082022, 235, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_6 = new CustomerDetails("Sanduni Perera", "Sanduni Address", 0763082022, 235, new DateTime(2015, 3, 22, 23, 45, 0));

            //  string customer_name, double phone_number, string billing_address, int total_call_charge, int total_discount, int tax, int rental, int bill_amount
            //  binfo_sut = new BillInformation();
        }

        [Test]
        public void ForMultipleCallRecordsForOnePerson_CheckDetailsOfAPerticularCustomer_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_1);
            bengine_sut.recordCallDetails(cdr_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_3);

            var expected = 14;

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
     /*   [Test]
        public void ForMultipleCallRecordsForOnePerson_CheckDetailsOfAPerticularCustomer_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_1);
            bengine_sut.recordCallDetails(cdr_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_3);

            var expected = 14;

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }*/
    }
}
