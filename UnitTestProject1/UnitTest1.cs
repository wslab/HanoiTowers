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
            Towers tower = new Towers(5);
            Assert.AreEqual(tower.numberOfDiscs, 5);
        }
    }
}
