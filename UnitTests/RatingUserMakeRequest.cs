using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserMakeRequest
    {
        [TestMethod]
        public void MakeRequest()
        {
            var ru = new RatingUser();
            var rateable = new Rateable();
            Request r = ru.UserRateRequest(rateable, 4);

            Assert.AreEqual(r.UserRate, 4);
        }
    }
}
