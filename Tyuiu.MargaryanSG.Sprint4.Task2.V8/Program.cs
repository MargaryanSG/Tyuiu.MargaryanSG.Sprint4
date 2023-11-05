using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint4.Task2.V8.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.Title = "Спринт 4. Выполнил: Маргарян С.Г. | ПКТб-23-1";
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* Спринт #4                                                     ");
            Console.WriteLine("* Тема: Случайные массивы                                       ");
            Console.WriteLine("* Задание #2                                                    ");
            Console.WriteLine("* Вариант #8                                                    ");
            Console.WriteLine("* Выполнил: Маргарян С.Г  | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан одномерный целочисленный массив на 11 элементов заполненный " +
                "случайными в диапазоне от 2 до 7 подсчитать сумму нечетных элементов массива. ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Random rand = new Random();
            Console.WriteLine("*Введите размер массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] array = new int[len];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(2, 7);
            }
            Console.Write("Массив: \n");
            for (int i = 0; i < len; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            int sum = DataService.Calculate(array);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

}