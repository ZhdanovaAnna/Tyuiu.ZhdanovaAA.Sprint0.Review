using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZhdanovaAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.TaskReview.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнила: Жданова А. А. | ПКТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Тестирование по спринту                                           *");
            Console.WriteLine("* Задание: SprintReview                                                   *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнила: Жданова Анна Александровна                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая вычисляет следущее         *");
            Console.WriteLine("* выражение (x + y + z) * 5                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();


            int x = 20, y = 2, z = 15;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");
            Console.WriteLine($"Z = {z}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"(x + y + z) * 5 = {DataService.Calc(x, y, z)}");
            Console.ReadKey();
        }
    }
} 
