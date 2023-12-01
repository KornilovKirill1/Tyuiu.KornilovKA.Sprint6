using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint6.Task2.V21.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            double[] wait = { 15.19, 11.67, 9, 0, 4.08, 1.5, -2.28, -6.52, -10.19, -12.76, -14.68 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
