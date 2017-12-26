using NUnit.Framework;
using MobileBillingEngine;
using System

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class BillingEngineTest
    {
        private CallDetailRecordsImp cdr_sut;
        private BillingEngingImp bengine_sut;
        private BillInformation binfo_sut;
        private CustomerDetails cusdetails_sut;

        [SetUp]
        public void Setup()
        {
            cdr_sut = new CallDetailRecords();
            bengine_sut = new BillingEngine();
            binfo_sut = new BillInformation();
            cusdetails_sut = new CustomerDetails("Shehan Erange", "Billing Address", 0773082022, 377, new DateTime(2015,3,22));

            //cdr for myself
            cdr_sut.setCallingParty(0773082022);
            cdr_sut.setRecievingParty(0333334184);
            cdr_sut.setStartingTime(new DateTime(2017, 3, 23));
            cdr_sut.setCallDuration(120);


        }

        [Test]
        public void SetDuration_AsANegativeNumber_ThrowExceptions()
        {
            
        }

    }
}
