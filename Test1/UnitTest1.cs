using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestPP02;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double min = 100;
            bool rad = true;
            double exp = 70;

            double actual = Convert.ToDouble(Class1.tarifMin(rad, min).Item1);
            Assert.AreEqual(exp, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double min = -1;
            bool rad = true;
            double exp = 140;

            double actual = Convert.ToDouble(Class1.tarifMin(rad, min).Item1);
            Assert.AreEqual(exp, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double min = 300;
            bool rad = false;
            double exp = 350;

            double actual = Convert.ToDouble(Class1.tarifMin(rad, min).Item1);
            Assert.AreEqual(exp, actual);
        }
    }
}
