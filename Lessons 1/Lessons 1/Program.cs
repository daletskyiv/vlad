using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число");

                double firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число");

                double secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите одно действие из +, -, * или / ");

                char act = char.Parse(Console.ReadLine());

                if (act == '+')
                {
                    double result = firstValue + secondValue;

                    Console.WriteLine("Результат = " + result);
                }
                else if (act == '-')
                {
                    double result = firstValue - secondValue;

                    Console.WriteLine("Результат = " + result);
                }
                else if (act == '*')
                {
                    double result = firstValue * secondValue;

                    Console.WriteLine("Результат = " + result);
                }
                else if (act == '/')
                {
                    if (secondValue == 0)
                        Console.WriteLine("Ошибка - деление на ноль!");
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else
                {
                    Console.WriteLine("Неккоректный ввод");
                }
            }
        }

    }
}
