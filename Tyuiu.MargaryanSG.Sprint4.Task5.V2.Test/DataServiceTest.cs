using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint4.Task5.V2.Lib;
namespace Tyuiu.MargaryanSG.Sprint4.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChangeValuesInMatrix()
        {
            DataService DataService = new DataService();
            int[,] matrix = { { -1, 3, 2, -2, 5 }, { -6, 1, 5, 5, 2 }, { 1, 5, -4, 1, -4 }, { 4, 1, -4, 4, 5 }, { 4, -6, -1, 1, 4 } };
            int wait = 8;
            int res = DataService.Calculate(matrix);
            Assert.AreEqual(res, wait);
        }
    }
}