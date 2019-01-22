using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserAddLikes
    {
        [TestMethod]
        public void AddLikes()
        {
            var ru = new RatingUser();
            var rateable = new Rateable();
            ru.Likes.Add(rateable);

            Assert.IsTrue(ru.Likes.Contains(rateable));
            //Assert.AreEqual(ru.Dislikes, null);
            //Assert.AreEqual(ru.Recommended, null);
        }
    }
}
