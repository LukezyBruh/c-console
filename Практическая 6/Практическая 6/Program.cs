// Практическая 6 шапка
/*Ввести последовательность целых чисел. Вычислять сумму чисел в диапазоне 
от - 3 до 7, пока эта сумма не превышает некоторого числа K. Вывести на экран 
сгенерированные числа, значение суммы, и количество сгенерированных чисел*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, 
                x = 0, 
                k, 
                sum= 0;
            Console.WriteLine("Введите число к ");
            k = Convert.ToInt32(Console.ReadLine());
            while (sum < k)
            {
                Console.WriteLine("Введите значение x = ");
                x = Convert.ToInt32(Console.ReadLine());
                if (x > -3 && x < 7)
                {
                    i++;
                    sum = sum + x;
                    Console.WriteLine("Сгенерированное число = " + x);
                }
                else
                {
                    Console.WriteLine("Некорректное число");
                }
                Console.WriteLine("Сумма = " + sum);
                Console.WriteLine("Кол-во чисел = " + i);
                Console.ReadKey();
            }
        }
    }
}
