using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class RateableCreate
    {
        [TestMethod]
        public void CreateDefault()
        {
            Rateable r = new Rateable();

            Assert.AreEqual(r.ClassName, null);
            Assert.AreEqual(r.RateValue, 0.0);
            Assert.AreEqual(r.Users, null);
            Assert.AreEqual(r.Votes, 0);
        }
    }
}
