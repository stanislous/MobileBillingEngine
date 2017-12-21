using System;
using NUnit.Framework;
using 

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class BillingEngineTest
    {
        private BillingEngineImp _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new NumberToWords();
        }
    }
}
