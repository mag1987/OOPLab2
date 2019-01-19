using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserCreate
    {
        [TestMethod]
        public void CreateDefault()
        {
            var ru = new RatingUser();
            Assert.AreEqual(ru.Likes, null);
            Assert.AreEqual(ru.Dislikes, null);
            Assert.AreEqual(ru.Recommended, null);
        }
    }
}
