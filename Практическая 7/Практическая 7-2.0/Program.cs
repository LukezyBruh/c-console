/* Гуреева ИПС-23 11.11.2021
Дана непустая последовательность неотрицательных целых чисел, 
оканчивающаяся отрицательным числом. Найти среднее арифметическое всех чисел 
последовательности (без учета отрицательного числа).

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_7_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, // текущее число
                i = 0, // кол-во введенных чисел
                s = 0, // сумма всх чисел
                sr_arif = 0;
            do
            {
                
                a = Convert.ToInt32(Console.ReadLine()); // ввод чисел
                if (a >= 0)
                {
                    s = s + a;
                    i++;
                    sr_arif = s / i;
                }
            } while (a >= 0);

                Console.WriteLine("Среднее арифметическое = " + sr_arif);
                Console.ReadKey(); // пауза
            
        }
    }
}
