using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint4.Task3.V21.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 4. Выполнил: Галямеев М.Р. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Двумерные массивы                                       ");
            Console.WriteLine("* Задание #3                                                    ");
            Console.WriteLine("* Вариант #21                                                   ");
            Console.WriteLine("* Выполнил: Маргарян С.Г. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан двумерный целочисленный массив 5 на 5 элементов, заполненный статическими значениями" +
                " в диапазоне от 3 до 8. Найдите произведение элементов в последнем столбце массива. ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine();
            int[,] array = { { 8, 3, 3, 3, 5 }, { 6, 7, 3, 3, 7 }, { 4, 5, 4, 6, 6 }, { 5, 5, 8, 8, 7 }, { 4, 6, 6, 7, 7 } };
            Console.WriteLine("Двумерный массив: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            


            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine();
            int r = DataService.Calculate(array);
            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

