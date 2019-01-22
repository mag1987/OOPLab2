using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RecommendingSystemUpdateUserFavourites
    {
        [TestMethod]
        public void UpdateLikes()
        {
            var rateable1 = new Rateable
            {
                RateValue = 4.0
            };
            var topRateables = new List<IRateable>();
            topRateables.Add(rateable1);
            var user = new RatingUser();
            var request = new Request
            {
                User = user
            };
            var top = new Top
            {
                Rateables = topRateables
            };
            var rs = new RecommendingSystem();

            rs.Recommend(request, top);

            Assert.IsTrue(user.Recommended.Contains(rateable1));
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
