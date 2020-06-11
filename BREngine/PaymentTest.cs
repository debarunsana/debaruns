using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Payment;

namespace BREngine
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void TestProduct()
        {
            PaymentTypeFact paymentfact = null;
            paymentfact = new PhysicalProductFact(1000);
            var val = paymentfact.GetPayment();
            Assert.AreEqual(1000, val.PaymentAmount);
        }
    }
}
