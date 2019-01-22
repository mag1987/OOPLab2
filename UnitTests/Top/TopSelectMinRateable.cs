using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class TopSelectMinRateable
    {
        [TestMethod]
        public void SelectMinRateable()
        {
            var top = new Top();
            var r1 = new Rateable
            {
                RateValue = 4
            };
            var r2 = new Rateable
            {
                RateValue = 5
            };
            var r3 = new Rateable
            {
                RateValue = 6
            };
            top.Rateables.Add(r1);
            top.Rateables.Add(r2); // list 4, 5
            top.Rateables.Sort(); // 5, 4
            var request = new Request
            {
                Rateable = r3
            };
            top.NumberOfTop = 5;
            top.RequestHandler(request);
            //top.Rateables.Add(request.Rateable);
            //top.Rateables.Sort();
            

            //Assert.AreEqual(top.Rateables.Last().RateValue, 4.0);
            //Assert.AreEqual(top.MinRateable.RateValue, r1.RateValue);
            Assert.AreSame(top.MinRateable, r1);
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
