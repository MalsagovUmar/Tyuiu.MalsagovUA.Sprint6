using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint6.Task3.V28.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                           { -13, -11, -20, -15, 9 },
                                           { 18, 13, -12, -15, -11 },
                                           { 10, -2, 19, -4, -10 },
                                           { 6, -20, -4, 13, -14 } };

            int[,] waitarray = new int[5, 5] { { -9, 8, 9, 16, -18 },
                                           { -13, -11, -20, -15, 9 },
                                           { 18, 13, -12, -15, -11 },
                                           { 0, 0, 19, 0, 0 },
                                           { 6, -20, -4, 13, -14 } };

            int[,] resarray = ds.Calculate(array);
            CollectionAssert.AreEqual(waitarray, resarray);
        }
    }
}
