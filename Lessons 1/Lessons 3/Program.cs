using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_3
{
    class Program
    {

        /*
         * Подсчёт количества и суммы чётных и нечётных чисел
         */
        static void Main(string[] args)
        {
            uint oddNumbers = 0;
            uint evenNumders = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Введите число начала диапазона");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число конца диапазона");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumders++;
                    evenNumbersSum += currentValue;
                }
                else 
                {
                    oddNumbers++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Количество чётных чисел = " + evenNumders);
            Console.WriteLine("Количество нечётных чисел = " + oddNumbers);
            Console.WriteLine("Сумма чётных чисел = " + evenNumbersSum);
            Console.WriteLine("Сумма нечётных чисел = " + oddNumbersSum);

        }
    }
}
