using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MargaryanSG.Sprint4.Task0.V26.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task0.V26
{
    class Program
    {
        static void Main(string[] args)

        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] array = new int[] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };

            Console.WriteLine("Массив " + array);

            int s = ds.GetSumOddArrEl(array);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
