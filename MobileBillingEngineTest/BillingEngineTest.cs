using NUnit.Framework;
using MobileBillingEngine;
using System;

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class BillingEngineTest
    {
        private CallDetailRecordsImp cdr_sut_1;
        private CallDetailRecordsImp cdr_sut_2;
        private CallDetailRecordsImp cdr_sut_3;
        private CallDetailRecordsImp cdr_sut_4;

        private CustomerDetails cusdetails_sut_1;
        private CustomerDetails cusdetails_sut_2;
        private CustomerDetails cusdetails_sut_3;
        private CustomerDetails cusdetails_sut_4;

        private BillingEngingImp bengine_sut;
        private BillInformation binfo_sut;
        

        [SetUp]
        public void Setup()
        {
            bengine_sut = new BillingEngine();

            ///////////////////////////Call Record Details//////////////////////////////

            cdr_sut_1 = new CallDetailRecords();
            //cdr for 1
            cdr_sut_1.setCallingParty(0773082022);
            cdr_sut_1.setRecievingParty(0333334184);
            cdr_sut_1.setStartingTime(new DateTime(2017, 3, 23));
            cdr_sut_1.setCallDuration(120);
            bengine_sut.recordCallDetails(cdr_sut_1);

            cdr_sut_2 = new CallDetailRecords();
            //cdr for 2
            cdr_sut_2.setCallingParty(0713082022);
            cdr_sut_2.setRecievingParty(0334334184);
            cdr_sut_2.setStartingTime(new DateTime(2017, 3, 23));
            cdr_sut_2.setCallDuration(120);
            bengine_sut.recordCallDetails(cdr_sut_2);

            cdr_sut_3 = new CallDetailRecords();
            //cdr for 3
            cdr_sut_3.setCallingParty(0763082022);
            cdr_sut_3.setRecievingParty(0332334184);
            cdr_sut_3.setStartingTime(new DateTime(2017, 3, 23));
            cdr_sut_3.setCallDuration(120);
            bengine_sut.recordCallDetails(cdr_sut_3);

            cdr_sut_4 = new CallDetailRecords();
            //cdr for 4
            cdr_sut_4.setCallingParty(0753082022);
            cdr_sut_4.setRecievingParty(0331334184);
            cdr_sut_4.setStartingTime(new DateTime(2017, 3, 23));
            cdr_sut_4.setCallDuration(120);
            bengine_sut.recordCallDetails(cdr_sut_4);

            ///////////////////////////////Customer Details////////////////////////////////

            cusdetails_sut_1 = new CustomerDetails("Shehan Erange", "Shehan Address", 0773082022, 377, new DateTime(2015, 3, 22));
            cusdetails_sut_2 = new CustomerDetails("Menuka Nayanadipa", "Menuka Address", 0763082022, 454, new DateTime(2015, 3, 22));
            cusdetails_sut_3 = new CustomerDetails("Sachini Perera", "sachini Address", 0753082022, 235, new DateTime(2015, 3, 22));
            

            //  string customer_name, double phone_number, string billing_address, int total_call_charge, int total_discount, int tax, int rental, int bill_amount
            //  binfo_sut = new BillInformation();
        }

        [Test]
        public void BillingEnginePrimaryWork_CheckDetailsOfAPerticularCustomer_ReturnThree()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_1);
            bengine_sut.recordCustomerDetails(cusdetails_sut_2);
            bengine_sut.recordCustomerDetails(cusdetails_sut_3);
            var expected = 3;

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected,result);

        }

    }
}
