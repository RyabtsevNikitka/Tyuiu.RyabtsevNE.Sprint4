﻿using Tyuiu.RyabtsevNE.Sprint4.Task2.V14.Lib;

namespace Tyuiu.RyabtsevNE.Sprint4.Task2.V14.Test
{
    [TestClass]
    public class DaraServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 1, 3, 5, 4, 2, 6, 0, 8, 4, 2, 6, 10 };
            int wait = 15;
            var res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
