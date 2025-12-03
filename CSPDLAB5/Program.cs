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
                // Уравнение 1: y = (2x - 7) / sqrt(3x + 21)
                if (x > -7)
                {
                    double y1 = (2 * x - 7) / Math.Sqrt(3 * x + 21);
                    Console.WriteLine($"Результат 1: y = {y1:F4}");
                }
                else
                {
                    Console.WriteLine("Результат 1: Невозможно вычислить (корень из отрицательного числа или деление на 0)");
                }

                // Уравнение 2: y = x / sqrt(x - 1)
                if (x > 1)
                {
                    double y2 = x / Math.Sqrt(x - 1);
                    Console.WriteLine($"Результат 2: y = {y2:F4}");
                }
                else
                {
                    Console.WriteLine("Результат 2: Невозможно вычислить (x должен быть больше 1)");
                }

                // Уравнение 3: y = (x + 1)/(x - 1) + sqrt(x^2)
                if (x != 1)
                {
                    double y3 = ((x + 1) / (x - 1)) + Math.Sqrt(Math.Pow(x, 2));
                    Console.WriteLine($"Результат 3: y = {y3:F4}");
                }
                else
                {
                    Console.WriteLine("Результат 3: Невозможно вычислить (деление на ноль при x=1)");
                }
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