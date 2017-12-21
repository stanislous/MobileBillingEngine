using System;
using NUnit.Framework;
using MobileBillingEngine;

namespace MobileBillingEngineTest
{
    [TestFixture]
    public class BillingEngineTest
    {
        private BillingEngingImp _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new BillingEngine();
        }
    }
}
