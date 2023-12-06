using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KornilovKA.Sprint6.Task6.V17.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V17.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "wFrlYaZtHI XuLENkL BV ltxrhBXm HbJcPW";

            Assert.AreEqual(wait, res);
        }
    }
}
