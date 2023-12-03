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
            wait[0] = 13.81;
            wait[1] = 11.87;
            wait[2] = 9.87;
            wait[3] = 7.74;
            wait[4] = 5.36;
            wait[5] = 2.5;
            wait[6] = 0;
            wait[7] = 0.79;
            wait[8] = -1.75;
            wait[9] = -3.78;
            wait[10] = -5.71;
            CollectionAssert.AreEqual(result, wait);
        }
    }
}
