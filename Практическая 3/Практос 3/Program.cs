using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double x = 5.6,
                y;// ввод
            y = Math.Round(x - 5 + 1.87 * Math.Pow(Math.Exp(x),Math.Cos(x) * Math.Cos(Math.Sin(x))),2);//вычисление 
            Console.WriteLine("значение y = " + y);// вывод
            Console.ReadKey();// пауза
        }
    }
}
