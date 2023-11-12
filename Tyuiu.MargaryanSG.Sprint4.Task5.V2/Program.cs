using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint4.Task5.V2.Lib;
namespace Tyuiu.MargaryanSG.Sprint4.Task5.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 4. Выполнил: Маргарян С.Г. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Двумерные массивы                                       ");
            Console.WriteLine("* Задание #5                                                    ");
            Console.WriteLine("* Вариант #2                                                    ");
            Console.WriteLine("* Выполнил: Маргарян С.Г. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный" +
                " случайными значениями в диапазоне от -7 до 5. Найти количество отрицательных элементов.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine();
            int[,] mtrx = new int[5, 5];
            var rand = new Random();
            Console.WriteLine("Матрица: \n");
            for (int i = 0; i < mtrx.GetLength(0); i++)
            {
                for (int j = 0; j < mtrx.GetLength(1); j++)
                {
                    mtrx[i, j] = rand.Next(-7, 5);
                    Console.Write(mtrx[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            int res = DataService.Calculate(mtrx);
            Console.WriteLine(res);
            Console.WriteLine();
            
        }
    }
}