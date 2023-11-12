using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MargaryanSG.Sprint4.Task6.V24.Lib;

namespace Tyuiu.MargaryanSG.Sprint4.Task6.V24
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
            Console.WriteLine("* Задание #6                                                    ");
            Console.WriteLine("* Вариант #24                                                   ");
            Console.WriteLine("* Выполнил: Маргарян С.Г. | ПКТб-23-1                           ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                      ");
            Console.WriteLine("Дан строковый массив данных, используя класс Array, выведите элементы массива, " +
                "длина которых больше 7 символов.");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            string[] array = { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            Console.WriteLine("Элементы более чем с 7-ю символами: ");
            string[] newArray = DataService.Calculate(array);
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + "\t");

            }
            Console.ReadKey();
        }

    }
}
