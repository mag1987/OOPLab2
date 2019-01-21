using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserUpdatesFavorites
    {
        [TestMethod]
        public void UpdateDislikes()
        {
            var user = new RatingUser();
            var rateable = new Rateable
            {
                RateValue = 5.0
            };
            var r = new Request
            {
                User = user,
                UserRate = 4,
                Rateable= rateable
            };
            user.UpdateUserFavourites(r);

            Assert.IsTrue(user.Dislikes.Contains(rateable));
            Assert.IsFalse(user.Likes.Contains(rateable));
        }
        [TestMethod]
        public void UpdateLikes()
        {
            var user = new RatingUser();
            var rateable = new Rateable
            {
                RateValue = 4.0
            };
            var r = new Request
            {
                User = user,
                UserRate = 5,
                Rateable = rateable
            };
            user.UpdateUserFavourites(r);

            Assert.IsFalse(user.Dislikes.Contains(rateable));
            Assert.IsTrue(user.Likes.Contains(rateable));
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
