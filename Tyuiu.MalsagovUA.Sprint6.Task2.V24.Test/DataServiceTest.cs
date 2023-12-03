using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint6.Task2.V24.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task2.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] result = new double[stopValue - startValue + 1];
            result = dataService.GetMassFunction(startValue, stopValue);
            double[] wait = new double[stopValue - startValue + 1];
            wait[0] = -8.86;
            wait[1] = -7.19;
            wait[2] = -6.14;
            wait[3] = -4.76;
            wait[4] = -2.33;
            wait[5] = 1;
            wait[6] = 4.38;
            wait[7] = 0;
            wait[8] = 6.13;
            wait[9] = 7.07;
            wait[10] = 8.61;
            CollectionAssert.AreEqual(result, wait);
        }
    }
}
