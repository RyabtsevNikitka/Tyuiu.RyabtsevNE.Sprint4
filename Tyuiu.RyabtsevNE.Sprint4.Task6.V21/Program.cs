using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RyabtsevNE.Sprint4.Task6.V21.Lib;

namespace Tyuiu.RyabtsevNE.Sprint4.Task6.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Рябцев Н. Е. | СМАРТб-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                    *");
            Console.WriteLine("* Класс Array                                                                  *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #21                                                                  *");
            Console.WriteLine("* Выполнил: Рябцев Никита Евгеньевич | СМАРТб-24-1                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дан строковый массив данных                                                  *");
            Console.WriteLine("*используя класс Array подсчитайте количество элементов, длина которых меньше 8*");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            var week = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };

            Console.WriteLine("Исходный массив");
            for (int i = 0; i <= week.Length - 1; i++)
            {
                Console.WriteLine(week[i]);
            }


            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Количество элементов, длина которых меньше 8:                              *");

            int nums = ds.Calculate(week);

            Console.WriteLine(nums);
            Console.ReadKey();
        }
    }
}