using System;
using NUnit.Framework;
using MobileBillingEngine;

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class BillingEngineTest
    {
        private BillingEngingImp bengine_sut;
        private CallDetailRecordsImp cdr_sut; 

        [SetUp]
        public void Setup()
        {
            bengine_sut = new BillingEngine();
            cdr_sut = new CallDetailRecords();

            cdr_sut.setCallingParty("077-3082022");
            cdr_sut.setRecievingParty("071-123456");
            cdr_sut.setStartingTime(new DateTime(2017, 3, 24, 8, 15, 0));
            cdr_sut.setCallDuration(120);
            
        }
        [Test]
        public void SetCallDetsilsRecord_something_ReturnSameDetails()
        {
            //arrange


            //act


            //assert
           
        }
    }
}
