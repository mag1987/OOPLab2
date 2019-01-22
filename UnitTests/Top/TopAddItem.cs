using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab2;

namespace UnitTests
{
    [TestClass]
    public class TopAddItem
    {
        [TestMethod]
        public void AddItem()
        {
            var top = new Top();
            var rateable = new Rateable();
            top.Rateables.Add(rateable);

            Assert.IsTrue(top.Rateables.Contains(rateable));
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
