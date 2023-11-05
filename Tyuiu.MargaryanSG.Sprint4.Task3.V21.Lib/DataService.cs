using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MargaryanSG.Sprint4.Task3.V21.Lib
{
    public class DataService : ISprint4Task3V21
    {
        public int Calculate(int[,] array)
        {
            array = new int[,] { { 8, 3, 3, 3, 5 }, { 6, 7, 3, 3, 7 }, { 4, 5, 4, 6, 6 }, { 5, 5, 8, 8, 7 }, { 4, 6, 6, 7, 7 } };
            int r = 1;
            for (int i = 0; i < 5; i++)
            {
                r *= array[i, 4];
            }
            return r;

        }
    }
}