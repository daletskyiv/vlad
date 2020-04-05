using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_2
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

                string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("Ошибка - деление на ноль!");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    default:
                        Console.WriteLine("Неккоректный ввод");
                        break;
                }
            }
        }
    }
}
