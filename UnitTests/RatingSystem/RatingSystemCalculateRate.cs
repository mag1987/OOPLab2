using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingSystemCalculateRate
    {
        [TestMethod]
        public void CalculateRateKarmaOffRateValue0()
        {
            var user = new RatingUser();
            var rateable = new Rateable
            {
                RateValue = 0
            };
            var request = new Request
            {
                User = user,
                Rateable = rateable,
                UserRate = 4
            };
            var rs = new RatingSystem();
            rs.CalculateRate(request);

            Assert.AreEqual(rateable.RateValue, 4.0);
        }
        [TestMethod]
        public void CalculateRateKarmaOffRateValueNotNull()
        {
            var user = new RatingUser();
            var rateable = new Rateable
            {
                RateValue = 2,
                Votes = 1
            };
            var request = new Request
            {
                User = user,
                Rateable = rateable,
                UserRate = 4
            };
            var rs = new RatingSystem();
            rs.CalculateRate(request);

            Assert.AreEqual(rateable.RateValue, 3.0);
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
