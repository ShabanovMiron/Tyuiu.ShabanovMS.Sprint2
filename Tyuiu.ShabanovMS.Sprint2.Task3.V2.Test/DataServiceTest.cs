using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShabanovMS.Sprint2.Task3.V2.Lib;
namespace Tyuiu.ShabanovMS.Sprint2.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -2;
            double wait = -53;
            double res = ds.Calculate(x);
            Assert.AreEqual(res, wait);
        }
    }
}
