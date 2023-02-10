using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoreDotnetTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsFalse(0==0, "Both numbers should be equal");
        }
    }
}
