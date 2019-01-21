using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingSystemCreate
    {
        [TestMethod]
        public void CreateDefault()
        {
            var rs = new RatingSystem();
            Assert.AreEqual(rs.UserKarmaLimit, 0);
        }
    }
}
