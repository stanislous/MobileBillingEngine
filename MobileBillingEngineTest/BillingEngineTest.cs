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
        private CustomerDetails cusdetails_sut_15;
        private CustomerDetails cusdetails_sut_16;
        private CustomerDetails cusdetails_sut_17;
        private CustomerDetails cusdetails_sut_18;
        private CustomerDetails cusdetails_sut_19;
        private CustomerDetails cusdetails_sut_20;
        private CustomerDetails cusdetails_sut_21;
        private CustomerDetails cusdetails_sut_22;
        private CustomerDetails cusdetails_sut_23;

        private PackageA package_a;
        private PackageB package_b;
        private PackageC package_c;
        private PackageD package_d;

        [SetUp]
        public void Setup()
        {
            package_a = new PackageA();
            package_b = new PackageB();
            package_c = new PackageC();
            package_d = new PackageD();

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
            cdr_sut_4.setRecievingParty(0733082043);
            cdr_sut_4.setStartingTime(new DateTime(2017, 3, 23, 15, 30, 0));
            cdr_sut_4.setCallDuration(80);

            cdr_sut_5 = new CallDetailRecords();
            //cdr for 5
            cdr_sut_5.setCallingParty(0743082022);
            cdr_sut_5.setRecievingParty(0743082022);
            cdr_sut_5.setStartingTime(new DateTime(2017, 3, 23, 3, 30, 0));
            cdr_sut_5.setCallDuration(180);

            cdr_sut_6 = new CallDetailRecords();
            //cdr for 6
            cdr_sut_6.setCallingParty(0753082022);
            cdr_sut_6.setRecievingParty(0332334184);
            cdr_sut_6.setStartingTime(new DateTime(2017, 3, 23, 15, 30, 0));
            cdr_sut_6.setCallDuration(120);

            cdr_sut_7 = new CallDetailRecords();
            //cdr for 7
            cdr_sut_7.setCallingParty(0763082022);
            cdr_sut_7.setRecievingParty(0331334184);
            cdr_sut_7.setStartingTime(new DateTime(2017, 3, 23, 5, 30, 0));
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

            cdr_sut_12 = new CallDetailRecords();
            //cdr for 12
            cdr_sut_12.setCallingParty(0633082022);
            cdr_sut_12.setRecievingParty(0633082023);
            cdr_sut_12.setStartingTime(new DateTime(2017, 3, 23, 9, 30, 0));
            cdr_sut_12.setCallDuration(150);

            cdr_sut_13 = new CallDetailRecords();
            //cdr for 13
            cdr_sut_13.setCallingParty(0643082022);
            cdr_sut_13.setRecievingParty(0643082024);
            cdr_sut_13.setStartingTime(new DateTime(2017, 3, 23, 23, 30, 0));
            cdr_sut_13.setCallDuration(140);

            cdr_sut_14 = new CallDetailRecords();
            //cdr for 14
            cdr_sut_14.setCallingParty(0653082022);
            cdr_sut_14.setRecievingParty(0653082024);
            cdr_sut_14.setStartingTime(new DateTime(2017, 3, 23, 7, 50, 0));
            cdr_sut_14.setCallDuration(1250);

            cdr_sut_15 = new CallDetailRecords();
            //cdr for 15
            cdr_sut_15.setCallingParty(0663082022);
            cdr_sut_15.setRecievingParty(0333082024);
            cdr_sut_15.setStartingTime(new DateTime(2017, 3, 23, 19, 50, 0));
            cdr_sut_15.setCallDuration(1250);

            ///////////////////////////////Customer Details////////////////////////////////

            cusdetails_sut_1 = new CustomerDetails("Shehan Erange", "Shehan Address", 0713082022, 1, new DateTime(2015, 3, 22, 15, 0, 0), "package A");
            cusdetails_sut_2 = new CustomerDetails("Menuka Nayanadipa", "Menuka Address", 0723082022, 2, new DateTime(2015, 3, 22, 6, 30, 0), "package A");
            cusdetails_sut_3 = new CustomerDetails("Sachini Perera", "sachini Address", 0733082022, 3, new DateTime(2015, 3, 22, 23, 45, 0), "package A");
            cusdetails_sut_4 = new CustomerDetails("Anuththara Perera", "Anuththara Address", 0743082022, 4, new DateTime(2015, 3, 22, 23, 45, 0), "package A");
            cusdetails_sut_5 = new CustomerDetails("Oshiini Perera", "Oshini Address", 0753082022, 5, new DateTime(2015, 3, 22, 23, 45, 0), "package A");
            cusdetails_sut_6 = new CustomerDetails("Sandun Perera", "Sandun Address", 0763082022, 6, new DateTime(2015, 3, 22, 23, 45, 0), "package A");
            cusdetails_sut_7 = new CustomerDetails("Naduni Perera", "Naduni Address", 0703082022, 7, new DateTime(2015, 2, 12, 4, 7, 0), "package A");
            cusdetails_sut_8 = new CustomerDetails("Hashini Perera", "Hashini Address", 0603082022, 8, new DateTime(2015, 2, 12, 4, 7, 0), "package A");
            cusdetails_sut_9 = new CustomerDetails("Waruni Perera", "Waruni Address", 0613082022, 9, new DateTime(2015, 2, 12, 9, 7, 0), "package A");
            cusdetails_sut_10 = new CustomerDetails("Waruna Perera", "Waruna Address", 0623082022, 10, new DateTime(2015, 2, 12, 9, 7, 0), "package A");
            cusdetails_sut_11 = new CustomerDetails("Sanduni Perera", "Sanduni Address", 0633082022, 11, new DateTime(2015, 2, 12, 9, 7, 0), "package B");
            cusdetails_sut_12 = new CustomerDetails("Nimal Perera", "Nimal Address", 0643082022, 12, new DateTime(2015, 2, 12, 9, 7, 0), "package B");
            cusdetails_sut_13 = new CustomerDetails("Srimal Perera", "Srimal Address", 0653082022, 13, new DateTime(2015, 2, 12, 9, 7, 0), "package B");
            cusdetails_sut_14 = new CustomerDetails("Sunil Perera", "Sunil Address", 0663082022, 14, new DateTime(2015, 2, 12, 9, 7, 0), "package B");

            cusdetails_sut_15 = new CustomerDetails("Nadun Perera", "Nadun Address", 0763082022, 15, new DateTime(2015, 2, 12, 4, 7, 0), "package C");
            cusdetails_sut_16 = new CustomerDetails("Hash Perera", "Hash Address", 0703082022, 16, new DateTime(2015, 2, 12, 4, 7, 0), "package C");
            cusdetails_sut_17 = new CustomerDetails("Maduka Perera", "Maduka Address", 0603082022, 17, new DateTime(2015, 2, 12, 9, 7, 0), "package C");
            cusdetails_sut_18 = new CustomerDetails("Samitha Perera", "Samitha Address", 0613082022, 18, new DateTime(2015, 2, 12, 9, 7, 0), "package C");
            cusdetails_sut_19 = new CustomerDetails("Harini Perera", "Harini Address", 0623082022, 19, new DateTime(2015, 2, 12, 9, 7, 0), "package C");
            cusdetails_sut_20 = new CustomerDetails("Sonali Perera", "Sonali Address", 0633082022, 20, new DateTime(2015, 2, 12, 9, 7, 0), "package D");
            cusdetails_sut_21 = new CustomerDetails("Pipuni Perera", "Pipuni Address", 0643082022, 21, new DateTime(2015, 2, 12, 9, 7, 0), "package D");
            cusdetails_sut_22 = new CustomerDetails("Nimali Perera", "Nimali Address", 0653082022, 22, new DateTime(2015, 2, 12, 9, 7, 0), "package D");
            cusdetails_sut_23 = new CustomerDetails("Himali Perera", "Himali Address", 0663082022, 23, new DateTime(2015, 2, 12, 9, 7, 0), "package D");

        }
        [Test]
        public void ForMultipleCallRecordsForOnePersonAtPackageA_CheckDetailsOfAPerticularCustomer_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_2);
            package_a.recordCallDetails(cdr_sut_1);
            package_a.recordCallDetails(cdr_sut_2);
            package_a.recordCallDetails(cdr_sut_3);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0723082022", 290.4 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LocalPeakHoursCallsOnly_ReturntotoalPayment()
           {
               //arrange
               package_a.recordCustomerDetails(cusdetails_sut_3);
               package_a.recordCallDetails(cdr_sut_4);
               Dictionary<string, double> expected = new Dictionary<string, double>() { { "0733082022", 127.2 } };
               
               //act 
               var result = package_a.generateBills();

               //assert
               Assert.AreEqual(expected, result);
           }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LocalOffPeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_4);
            package_a.recordCallDetails(cdr_sut_5);

            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0743082022", 127.2 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LongDistancePeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_5);
            package_a.recordCallDetails(cdr_sut_6);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0753082022", 132 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LongDistanceOffPeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_6);
            package_a.recordCallDetails(cdr_sut_7);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0763082022", 129.6 } };
            
            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LocalFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_7);
            package_a.recordCallDetails(cdr_sut_8);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0703082022", 168 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LocalFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_8);
            package_a.recordCallDetails(cdr_sut_9);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0603082022", 168 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LongDistanceFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_9);
            package_a.recordCallDetails(cdr_sut_10);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0613082022", 216 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageA_LongDistanceFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_a.recordCustomerDetails(cusdetails_sut_10);
            package_a.recordCallDetails(cdr_sut_11);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0623082022", 216 } };

            //act 
            var result = package_a.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageB_LocalPeakHoursCallsOnly_ReturntotoalPayment()
        {
            //arrange
            package_b.recordCustomerDetails(cusdetails_sut_11);
            package_b.recordCallDetails(cdr_sut_12);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0633082022", 132 } };

            //act 
            var result = package_b.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageB_LocalOffPeakHoursCallsOnly_ReturntotoalPayment()
        {
            //arrange
            package_b.recordCustomerDetails(cusdetails_sut_12);
            package_b.recordCallDetails(cdr_sut_13);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0643082022", 124.8 } };

            //act 
            var result = package_b.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageB_LocalFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_b.recordCustomerDetails(cusdetails_sut_13);
            package_b.recordCallDetails(cdr_sut_14);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0653082022", 203.4 } };

            //act 
            var result = package_b.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageB_LongDistanceFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_b.recordCustomerDetails(cusdetails_sut_14);
            package_b.recordCallDetails(cdr_sut_15);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0663082022", 258 } };

            //act 
            var result = package_b.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageC_LongDistanceOffPeakHoursCallOnly_ReturntotoalPayment()
        {
            //arrange
            package_c.recordCustomerDetails(cusdetails_sut_15);
            package_c.recordCallDetails(cdr_sut_7);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0763082022", 364.8 } };

            //act 
            var result = package_c.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageC_LocalFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_c.recordCustomerDetails(cusdetails_sut_16);
            package_c.recordCallDetails(cdr_sut_8);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0703082022", 382.8 } };

            //act 
            var result = package_c.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageC_LocalFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_c.recordCustomerDetails(cusdetails_sut_17);
            package_c.recordCallDetails(cdr_sut_9);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0603082022", 382.8 } };

            //act 
            var result = package_c.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageC_LongDistanceFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_c.recordCustomerDetails(cusdetails_sut_18);
            package_c.recordCallDetails(cdr_sut_10);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0613082022", 408 } };

            //act 
            var result = package_c.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerMinuteAtPackageC_LongDistanceFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_c.recordCustomerDetails(cusdetails_sut_19);
            package_c.recordCallDetails(cdr_sut_11);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0623082022", 408 } };

            //act 
            var result = package_c.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageD_LocalPeakHoursCallsOnly_ReturntotoalPayment()
        {
            //arrange
            package_d.recordCustomerDetails(cusdetails_sut_20);
            package_d.recordCallDetails(cdr_sut_12);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0633082022", 369 } };

            //act 
            var result = package_d.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageD_LocalOffPeakHoursCallsOnly_ReturntotoalPayment()
        {
            //arrange
            package_d.recordCustomerDetails(cusdetails_sut_21);
            package_d.recordCallDetails(cdr_sut_13);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0643082022", 365.6 } };

            //act 
            var result = package_d.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageD_LocalFromOffPeakToPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_d.recordCustomerDetails(cusdetails_sut_22);
            package_d.recordCallDetails(cdr_sut_14);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0653082022", 422.00000000000006 } };

            //act 
            var result = package_d.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void FindTheCallChargeForPerSecondAtPackageD_LongDistanceFromPeakToOffPeakHoursCall_ReturntotoalPayment()
        {
            //arrange
            package_d.recordCustomerDetails(cusdetails_sut_23);
            package_d.recordCallDetails(cdr_sut_15);
            Dictionary<string, double> expected = new Dictionary<string, double>() { { "0663082022", 473.00000000000006 } };

            //act 
            var result = package_d.generateBills();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
