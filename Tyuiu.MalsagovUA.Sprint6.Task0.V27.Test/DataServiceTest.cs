using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint6.Task0.V27.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int x = 4;
            double res = ds.Calculate(x);
            double wait = -6;
            Assert.AreEqual(wait, res);
        }
    }
}
