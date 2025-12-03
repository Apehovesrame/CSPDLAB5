using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPDLAB5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2. Расчет уравнений.");
            Console.Write("Введите значение X: ");

            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine($"Вы ввели X = {x}");
            }
            else
            {
                Console.WriteLine("Ошибка: введено не число.");
            }

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}