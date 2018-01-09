using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_BitCounting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryIt_Input_1_Should_Be_1()
        {
            Assert.AreEqual("1", Kata.BinaryIt(1));
        }

        [TestMethod]
        public void BinaryIt_Input_2_Should_Be_1()
        {
            Assert.AreEqual("10", Kata.BinaryIt(2));
        }

        [TestMethod]
        public void Input_2_Should_Be_1()
        {
            Assert.AreEqual(1,Kata.CountBits(2));
        }
    }

    public class Kata
    {
        public static string BinaryIt(int n)
        {
            return Convert.ToString(n, 2);
        }

        public static int CountBits(int n)
        {
            throw new NotImplementedException();
        }
    }
}
