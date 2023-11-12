using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint4.Task6.V24.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckWordsInArray()
        {
            DataService DataService = new DataService();
            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            string[] newArray = new string[] { "Компьютер", "Клавиатура" };
            string[] result = DataService.Calculate(array);
            CollectionAssert.AreEqual(result, newArray);
        }
    }
}