using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KornilovKA.Sprint6.Task4.V23.Lib;

namespace Tyuiu.KornilovKA.Sprint6.Task4.V23.Test
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

            double[] wait = { 13.81, 11.87, 9.87, 7.74, 5.36, 2.5, 0, 0.79, -1.75, -3.78, -5.71 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
