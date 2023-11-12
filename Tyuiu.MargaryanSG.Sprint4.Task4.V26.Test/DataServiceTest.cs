﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MargaryanSG.Sprint4.Task4.V26.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ChangeIndexInMatrix()
        {
            DataService DataService = new DataService();
            int[,] matrix = { { 5, 4, 1, 1, 2 }, { 3, 2, 4, 3, 5 }, { 5, 2, 3, 2, 2,}, { 2, 5, 1, 1, 4 }, { 5, 3, 4, 3, 2 } };
            int[,] waitMatrix = { { 0, 4, 0, 0, 2 }, { 0, 2, 4, 0, 0 }, { 0, 2, 0, 2, 2 }, { 2, 0, 0, 0, 4 }, { 0, 0, 4, 0, 2 } };
            int[,] wait = DataService.Calculate(matrix);
            CollectionAssert.AreEqual(waitMatrix, wait);
        }
    }
}