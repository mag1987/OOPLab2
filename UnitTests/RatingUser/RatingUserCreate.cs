using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
            Assert.IsInstanceOfType(ru.Likes, typeof(HashSet<IRateable>));
            Assert.IsInstanceOfType(ru.Dislikes, typeof(HashSet<IRateable>));
            Assert.IsInstanceOfType(ru.Recommended, typeof(HashSet<IRateable>));
        }
    }
}
