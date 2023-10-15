using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint2.Task5.V10.Lib;
namespace Tyuiu.ShabanovMS.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 10;
            int n = 31;
            string wait = (30 + "." + 10 + "." + 2023);
            string res = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(res, wait);
        }
    }
}
