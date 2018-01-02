using NUnit.Framework;
using MobileBillingEngine;
using System;
using System.Collections.Generic;

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
        private CallDetailRecords cdr_sut_8;
        private CallDetailRecords cdr_sut_9;
        private CallDetailRecords cdr_sut_10;
        private CallDetailRecords cdr_sut_11;
        private CallDetailRecords cdr_sut_12;
        private CallDetailRecords cdr_sut_13;
        private CallDetailRecords cdr_sut_14;
        private CallDetailRecords cdr_sut_15;

        private CustomerDetails cusdetails_sut_1;
        private CustomerDetails cusdetails_sut_2;
        private CustomerDetails cusdetails_sut_3;
        private CustomerDetails cusdetails_sut_4;
        private CustomerDetails cusdetails_sut_5;
        private CustomerDetails cusdetails_sut_6;
        private CustomerDetails cusdetails_sut_7;
        private CustomerDetails cusdetails_sut_8;
        private CustomerDetails cusdetails_sut_9;
        private CustomerDetails cusdetails_sut_10;
        private CustomerDetails cusdetails_sut_11;
        private CustomerDetails cusdetails_sut_12;
        private CustomerDetails cusdetails_sut_13;
        private CustomerDetails cusdetails_sut_14;

        private BillingEngingImp bengine_sut;
        // private BillInformation binfo_sut;

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
            cdr_sut_1.setBillingType("per minute");

            cdr_sut_2 = new CallDetailRecords();
            //cdr for 2
            cdr_sut_2.setCallingParty(0723082022);
            cdr_sut_2.setRecievingParty(0334334184);
            cdr_sut_2.setStartingTime(new DateTime(2017, 3, 23, 12, 34, 0));
            cdr_sut_2.setCallDuration(120);
            cdr_sut_2.setBillingType("per minute");

            cdr_sut_3 = new CallDetailRecords();
            //cdr for 3
            cdr_sut_3.setCallingParty(0723082022);
            cdr_sut_3.setRecievingParty(0332334184);
            cdr_sut_3.setStartingTime(new DateTime(2017, 3, 23, 16, 34, 0));
            cdr_sut_3.setCallDuration(120);
            cdr_sut_3.setBillingType("per minute");

            cdr_sut_4 = new CallDetailRecords();
            //cdr for 4
            cdr_sut_4.setCallingParty(0733082022);
            cdr_sut_4.setRecievingParty(0733082043);
            cdr_sut_4.setStartingTime(new DateTime(2017, 3, 23, 15, 30, 0));
            cdr_sut_4.setCallDuration(80);
            cdr_sut_4.setBillingType("per minute");

            cdr_sut_5 = new CallDetailRecords();
            //cdr for 5
            cdr_sut_5.setCallingParty(0743082022);
            cdr_sut_5.setRecievingParty(0743082022);
            cdr_sut_5.setStartingTime(new DateTime(2017, 3, 23, 3, 30, 0));
            cdr_sut_5.setCallDuration(180);
            cdr_sut_5.setBillingType("per minute");

            cdr_sut_6 = new CallDetailRecords();
            //cdr for 6
            cdr_sut_6.setCallingParty(0753082022);
            cdr_sut_6.setRecievingParty(0332334184);
            cdr_sut_6.setStartingTime(new DateTime(2017, 3, 23, 15, 30, 0));
            cdr_sut_6.setCallDuration(120);
            cdr_sut_6.setBillingType("per minute");

            cdr_sut_7 = new CallDetailRecords();
            //cdr for 7
            cdr_sut_7.setCallingParty(0763082022);
            cdr_sut_7.setRecievingParty(0331334184);
            cdr_sut_7.setStartingTime(new DateTime(2017, 3, 23, 5, 30, 0));
            cdr_sut_7.setCallDuration(120);
            cdr_sut_7.setBillingType("per minute");

            cdr_sut_8 = new CallDetailRecords();
            //cdr for 8
            cdr_sut_8.setCallingParty(0703082022);
            cdr_sut_8.setRecievingParty(0703082029);
            cdr_sut_8.setStartingTime(new DateTime(2017, 3, 23, 19, 50, 0));
            cdr_sut_8.setCallDuration(20 * 60);
            cdr_sut_8.setBillingType("per minute");

            cdr_sut_9 = new CallDetailRecords();
            //cdr for 9
            cdr_sut_9.setCallingParty(0603082022);
            cdr_sut_9.setRecievingParty(0603082021);
            cdr_sut_9.setStartingTime(new DateTime(2017, 3, 23, 7, 50, 0));
            cdr_sut_9.setCallDuration(20 * 60);
            cdr_sut_9.setBillingType("per minute");

            cdr_sut_10 = new CallDetailRecords();
            //cdr for 10
            cdr_sut_10.setCallingParty(0613082022);
            cdr_sut_10.setRecievingParty(0333334184);
            cdr_sut_10.setStartingTime(new DateTime(2017, 3, 23, 19, 50, 0));
            cdr_sut_10.setCallDuration(20 * 60);
            cdr_sut_10.setBillingType("per minute");

            cdr_sut_11 = new CallDetailRecords();
            //cdr for 11
            cdr_sut_11.setCallingParty(0623082022);
            cdr_sut_11.setRecievingParty(0333334184);
            cdr_sut_11.setStartingTime(new DateTime(2017, 3, 23, 7, 50, 0));
            cdr_sut_11.setCallDuration(20 * 60);
            cdr_sut_11.setBillingType("per minute");

            cdr_sut_12 = new CallDetailRecords();
            //cdr for 12
            cdr_sut_12.setCallingParty(0633082022);
            cdr_sut_12.setRecievingParty(0633082023);
            cdr_sut_12.setStartingTime(new DateTime(2017, 3, 23, 9, 30, 0));
            cdr_sut_12.setCallDuration(140);
            cdr_sut_12.setBillingType("per second");

            cdr_sut_13 = new CallDetailRecords();
            //cdr for 13
            cdr_sut_13.setCallingParty(0643082022);
            cdr_sut_13.setRecievingParty(0643082024);
            cdr_sut_13.setStartingTime(new DateTime(2017, 3, 23, 23, 30, 0));
            cdr_sut_13.setCallDuration(140);
            cdr_sut_13.setBillingType("per second");

            cdr_sut_14 = new CallDetailRecords();
            //cdr for 14
            cdr_sut_14.setCallingParty(0653082022);
            cdr_sut_14.setRecievingParty(0653082024);
            cdr_sut_14.setStartingTime(new DateTime(2017, 3, 23, 7, 50, 0));
            cdr_sut_14.setCallDuration(20 * 60);
            cdr_sut_14.setBillingType("per second");

            cdr_sut_15 = new CallDetailRecords();
            //cdr for 15
            cdr_sut_15.setCallingParty(0663082022);
            cdr_sut_15.setRecievingParty(0333082024);
            cdr_sut_15.setStartingTime(new DateTime(2017, 3, 23, 19, 50, 0));
            cdr_sut_15.setCallDuration(20 * 60);
            cdr_sut_15.setBillingType("per second");

            ///////////////////////////////Customer Details////////////////////////////////

            cusdetails_sut_1 = new CustomerDetails("Shehan Erange", "Shehan Address", 0713082022, 1, new DateTime(2015, 3, 22, 15, 0, 0));
            cusdetails_sut_2 = new CustomerDetails("Menuka Nayanadipa", "Menuka Address", 0723082022, 2, new DateTime(2015, 3, 22, 6, 30, 0));
            cusdetails_sut_3 = new CustomerDetails("Sachini Perera", "sachini Address", 0733082022, 3, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_4 = new CustomerDetails("Anuththara Perera", "Anuththara Address", 0743082022, 4, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_5 = new CustomerDetails("Oshiini Perera", "Oshini Address", 0753082022, 5, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_6 = new CustomerDetails("Sandun Perera", "Sandun Address", 0763082022, 6, new DateTime(2015, 3, 22, 23, 45, 0));
            cusdetails_sut_7 = new CustomerDetails("Naduni Perera", "Naduni Address", 0703082022, 7, new DateTime(2015, 2, 12, 4, 7, 0));
            cusdetails_sut_8 = new CustomerDetails("Hashini Perera", "Hashini Address", 0603082022, 8, new DateTime(2015, 2, 12, 4, 7, 0));
            cusdetails_sut_9 = new CustomerDetails("Waruni Perera", "Waruni Address", 0613082022, 9, new DateTime(2015, 2, 12, 9, 7, 0));
            cusdetails_sut_10 = new CustomerDetails("Waruna Perera", "Waruna Address", 0623082022, 10, new DateTime(2015, 2, 12, 9, 7, 0));
            cusdetails_sut_11 = new CustomerDetails("Sanduni Perera", "Sanduni Address", 0633082022, 11, new DateTime(2015, 2, 12, 9, 7, 0));
            cusdetails_sut_12 = new CustomerDetails("Nimal Perera", "Nimal Address", 0643082022, 12, new DateTime(2015, 2, 12, 9, 7, 0));
            cusdetails_sut_13 = new CustomerDetails("Srimal Perera", "Srimal Address", 0653082022, 13, new DateTime(2015, 2, 12, 9, 7, 0));
            cusdetails_sut_14 = new CustomerDetails("Sunil Perera", "Sunil Address", 0663082022, 14, new DateTime(2015, 2, 12, 9, 7, 0));
        }
        [Test]
        public void ForMultipleCallRecordsForOnePerson_CheckDetailsOfAPerticularCustomer_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_1);
            bengine_sut.recordCallDetails(cdr_sut_2);
            bengine_sut.recordCallDetails(cdr_sut_3);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0723082022", 290.4 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LocalPeakHoursCallsOnly_ReturntotoalPayment()
           {
               //arrange
               bengine_sut.recordCustomerDetails(cusdetails_sut_3);
               bengine_sut.recordCallDetails(cdr_sut_4);
               Dictionary<string, double> expected = new Dictionary<string, double>() { { "0733082022", 127.2 } };
               
               //act 
               var result = bengine_sut.generateBills();

               //assert
               Assert.AreEqual(expected, result);
           }
        [Test]
        public void FindTheCallChargeForPerMinute_LocalOffPeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_4);
            bengine_sut.recordCallDetails(cdr_sut_5);

            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0743082022", 127.2 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LongDistancePeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_5);
            bengine_sut.recordCallDetails(cdr_sut_6);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0753082022", 132 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LongDistanceOffPeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_6);
            bengine_sut.recordCallDetails(cdr_sut_7);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0763082022", 129.6 } };
            
            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LocalFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_7);
            bengine_sut.recordCallDetails(cdr_sut_8);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0703082022", 180 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LocalFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_8);
            bengine_sut.recordCallDetails(cdr_sut_9);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0603082022", 180 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LongDistanceFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_9);
            bengine_sut.recordCallDetails(cdr_sut_10);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0613082022", 228 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinute_LongDistanceFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_10);
            bengine_sut.recordCallDetails(cdr_sut_11);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0623082022", 228 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecond_LocalPeakHoursCallsOnly_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_11);
            bengine_sut.recordCallDetails(cdr_sut_12);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0633082022", 130.8 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecond_LocalOffPeakHoursCallsOnly_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_12);
            bengine_sut.recordCallDetails(cdr_sut_13);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0643082022", 128.4 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecond_LocalFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_13);
            bengine_sut.recordCallDetails(cdr_sut_14);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0653082022", 204 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecond_LongDistanceFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            bengine_sut.recordCustomerDetails(cusdetails_sut_14);
            bengine_sut.recordCallDetails(cdr_sut_15);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0663082022", 252 } };

            //act 
            var result = bengine_sut.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
