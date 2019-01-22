using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserSendRequest
    {
        [TestMethod]
        public void SendRequest()
        {
            var ru = new RatingUser();
            var rateable = new Rateable();
            var wasCalled = false;

            ru.RateRequest += delegate (Request r) { wasCalled = true; };
            ru.UserRate(rateable, 3);

            Assert.IsTrue(wasCalled);
        }
    }
}
