using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using Tyuiu.MargaryanSG.Sprint4.Task3.V21.Lib;
namespace Tyuiu.MargaryanSG.Sprint4.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindMaxCountInArray()
        {
            DataService DataService = new DataService();
            int[,] array = { { 8, 3, 3, 3, 5 }, { 6, 7, 3, 3, 7 }, { 4, 5, 4, 6, 6 }, { 5, 5, 8, 8, 7 }, { 4, 6, 6, 7, 7 } };
            int wait = 10290;
            int res = DataService.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}