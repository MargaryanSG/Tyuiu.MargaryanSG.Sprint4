using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint4.Task7.V29.Lib;
namespace Tyuiu.MargaryanSG.Sprint4.Task7.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindCountsInString()
        {
            DataService DataService = new DataService();
            int n = 4;
            int m = 3;
            string value = "983157642891";
            int sum = 28;
            int calc = DataService.Calculate(n, m, value);
            Assert.AreEqual(calc, sum);
        }
    }
}
