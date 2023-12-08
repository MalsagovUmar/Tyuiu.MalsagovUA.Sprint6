using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

using Tyuiu.MalsagovUA.Sprint6.Task5.V17.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\malsu\source\repos\Tyuiu.MalsagovUA.Sprint6\Tyuiu.MalsagovUA.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
