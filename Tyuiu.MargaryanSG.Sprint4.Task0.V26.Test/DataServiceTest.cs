using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint4.Task0.V26.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 41;
            int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            int res = ds.GetSumOddArrEl(array);
            Assert.AreEqual(wait, res);
        }


    }
}
