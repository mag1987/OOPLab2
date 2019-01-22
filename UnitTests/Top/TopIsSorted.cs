using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class TopIsSorted
    {
        [TestMethod]
        public void SortByRate()
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
            top.Rateables.Add(r1);
            top.Rateables.Add(r2); // list 4, 5
            top.Rateables.Sort(); // 5, 4
            var array = top.Rateables.ToArray();
            Assert.IsTrue(array[0].RateValue > array[1].RateValue);
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
