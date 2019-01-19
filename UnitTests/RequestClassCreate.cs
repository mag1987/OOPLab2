using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RequestClassCreate
    {
        [TestMethod]
        public void CreateDefault()
        {
            var r = new Request();
            Assert.AreEqual(r.Rateable , null);
            Assert.AreEqual(r.User, null);
            Assert.AreEqual(r.UserRate, 0);
        }
    }
}
