using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingSystemInvokeUpdateRate
    {
        [TestMethod]
        public void InvokeUpdateRate()
        {
            var rs = new RatingSystem();
            var r = new Request
            {
                User = new RatingUser(),
                Rateable = new Rateable(),
                UserRate = 3
            };
            var wasCalled = false;
            rs.RateUpdated += delegate(Request request) { wasCalled = true; };

            rs.RequestHandler(r);
            Assert.IsTrue(wasCalled);
        }
    }
}
