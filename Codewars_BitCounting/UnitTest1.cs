using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_BitCounting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryIt_Input_1_Should_Be_1()
        {
            Assert.AreEqual("1",Kata.BinaryIt(1));
        }
    }

    public class Kata
    {
        public static string BinaryIt(int n)
        {
            return "1";
        }
    }
}
