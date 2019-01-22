using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class TopMinRateableAccess
    {
        [TestMethod]
        public void MinRateableWrite()
        {
            var top = new Top();
            var rateable = new Rateable
            {
                RateValue = 4
            };
            top.MinRateable = rateable;
            Assert.AreEqual(top.MinRateable.RateValue, 4.0);
        }
    }

    /*
     
    [TestClass]
    public class a
    {
        [TestMethod]
        public void aa() { }
    }

    */
}
