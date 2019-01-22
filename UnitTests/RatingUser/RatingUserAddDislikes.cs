using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserAddDislikes
    {
        [TestMethod]
        public void AddDislikes()
        {
            var ru = new RatingUser();
            var rateable = new Rateable();
            ru.Dislikes.Add(rateable);

            Assert.IsTrue(ru.Dislikes.Contains(rateable));
            //Assert.AreEqual(ru.Dislikes, null);
            //Assert.AreEqual(ru.Recommended, null);
        }
    }
}
