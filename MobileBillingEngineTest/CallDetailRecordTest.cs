using System;
using NUnit.Framework;
using MobileBillingEngine;

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class CallDetailRecordTest
    {
        //private BillingEngingImp bengine_sut;
        private CallDetailRecordsImp cdr_sut;

        [SetUp]
        public void Setup()
        {
            bengine_sut = new BillingEngine();
            cdr_sut = new CallDetailRecords();
        }
        [Test]
        public void SetRecievingPartyNumber_something_ReturnSameDetails()
        {
            //arrange
            var expected = "071-123456";
            cdr_sut.setRecievingParty(expected);

            //act
            var result = cdr_sut.getRecievingParty();

            //assert
            Assert.AreEqual(expected, result, "Should return same phone number.");
        }
        [Test]
        public void SetStartingTimeAndDuration_something_ReturnSameDetails()
        {
            //arrange
            var expected_date_time = new DateTime(2017, 3, 24, 8, 15, 0);
            var expected_call_duration = 120;
            cdr_sut.setStartingTime(expected_date_time);
            cdr_sut.setCallDuration(expected_call_duration);

            //act
            var result_date_time = cdr_sut.getStartingTime();
            var result_call_duration = cdr_sut.getCallDuration();

            //assert
            Assert.AreEqual(expected_date_time, result_date_time, "Should return same date time.");
            Assert.AreEqual(expected_call_duration,result_call_duration, "Should return same call duration.");
        }
        [Test]
        public void SetInvalidCallerPhoneNumber_AccessCatchBlock_ThrowException()
        {
            //arrange
            var expected ="071-12304506"; // Wrong Length
            cdr_sut.setRecievingParty(expected);

            //act
            var result = cdr_sut.getRecievingParty();

            //assert
            Assert.AreEqual(expected, result, "Should return same phone number.");
            Assert.Throws<ArgumentOutOfRangeException>(() => cdr_sut.setCallingParty(expected));
        }
    }
}
            
            