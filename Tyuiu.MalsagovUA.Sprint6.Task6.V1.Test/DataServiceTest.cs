using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.MalsagovUA.Sprint6.Task6.V1.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\malsu\InPutFileTask6V1.txt";
            string wait = "ainUD JnYbSEpE xRh rnAUGAubeiX phe  ";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
