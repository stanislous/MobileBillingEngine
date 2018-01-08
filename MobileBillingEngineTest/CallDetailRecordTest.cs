using System;
using NUnit.Framework;
using MobileBillingEngine;

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class CallDetailRecordTest
    {
        //private BillingEngingImp bengine_sut;
        private CallDetailRecords cdr_sut;

        [SetUp]
        public void Setup()
        {
            //bengine_sut = new BillingEngine();
            cdr_sut = new CallDetailRecords();
        }
        [Test]
        public void SetDuration_AsANegativeNumber_ThrowExceptions()
        {
            //arrange
            var expected = -120;

            //act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => cdr_sut.setCallDuration(expected));
        }
        [Test]
        public void SetNegastiveCallerPhoneNumber_AccessCatchBlock_ThrowException()
        {
            //arrange
            var expected = -0711234506; // Minus Number
            //act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => cdr_sut.setCallingParty(expected));
        }
        [Test]
        public void SetInvalidCallerPhoneNumber_AccessCatchBlock_ThrowException()
        {
            //arrange
            var expected = 71912034506; // Invalid Number
            //act & assert
            Assert.Throws<ArgumentOutOfRangeException>(() => cdr_sut.setCallingParty(expected));
        }
        [Test]
        public void SetTimeDurationInSeconds_RoundToMinutes_ReturnNewSeconds()
        {
            //arrange
            var expected = 120; // Invalid Number
            //act 
            cdr_sut.setCallDuration(80);
            var result = cdr_sut.getCallDuration();
            //assert
            Assert.AreEqual(expected,result);
        }
    }
}        