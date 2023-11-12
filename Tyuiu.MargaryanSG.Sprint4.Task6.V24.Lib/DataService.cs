using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MargaryanSG.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            array = new string[] { "Компьютер", "Телефон", "Планшет", "Принтер", "Сканер", "Монитор", "Клавиатура" };

            int count = 0;
            foreach (string item in array)
            {
                if (item.Length > 7)
                {
                    count++;
                }
            }
            string[] newArray = new string[count];
            int i = 0;
            foreach (string item in array)
            {
                if (item.Length > 7)
                {
                    newArray[i] = item;
                    i++;
                }
            }
            return newArray;
        }
    }
}