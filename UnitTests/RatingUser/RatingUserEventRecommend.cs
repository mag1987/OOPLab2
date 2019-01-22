using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class RatingUserEventRecommend
    {
        [TestMethod]
        public void RecommendEvent()
        {
            var user = new RatingUser();
            var top = new Top();
            var wasCalled = false;
            user.RecommendRequest += delegate (Request request, Top t) { wasCalled = true; };
            user.Recommend(top);

            Assert.IsTrue(wasCalled);
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
