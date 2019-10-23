using Microsoft.VisualStudio.TestTools.UnitTesting;
using HanoiClassLibrary;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tower tower = new Tower(5);
            Assert.AreEqual(tower.numberOfDisks, 5);
        }
    }
}
