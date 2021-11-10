using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibProject;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] input = new int[0];
            int exp_res = -1;
            int act_res = MyClass.IndexOfLastMin(input);
            Assert.AreEqual(exp_res, act_res, "Ой");
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] input = new int[] { 3};
            int exp_res = 0;
            int act_res = MyClass.IndexOfLastMin(input);
            Assert.AreEqual(exp_res, act_res, "Ой");
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] input = new int[] { 3, 4 };
            int exp_res = 0;
            int act_res = MyClass.IndexOfLastMin(input);
            Assert.AreEqual(exp_res, act_res, "Ой");
        }

        [TestMethod]
        public void TestMethod4()
        {
            int[] input = new int[] { 4,3};
            int exp_res = 1;
            int act_res = MyClass.IndexOfLastMin(input);
            Assert.AreEqual(exp_res, act_res, "Ой");
        }
    }
}
