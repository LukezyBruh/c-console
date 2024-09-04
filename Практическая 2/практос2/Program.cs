using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практос2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,
                b,
                c;
            double D;
            Console.WriteLine("Введите a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c=");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                D = a + b + c;
                Console.WriteLine("Одна из переменных равна нулю"+ D);
            }
             if (a == 0 && b == 0 && c == 0)
                {
                    Console.WriteLine("Все равны нулю");
                }
                else
                {
                    D = a * b * c;
                    Console.WriteLine("Произведениме равно" + D);
                }
                
            
            Console.ReadKey();

        }

    }
}
