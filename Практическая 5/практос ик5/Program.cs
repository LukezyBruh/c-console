//Практическая №5 - оператор цикла for
//Гуреева И.Д. 16.10.2021
using System;

namespace практос_ик5
{
    class Program
    {
        static void Main(string[] args)
        {
            double calcFunc,// Расч-я фун-я
                   anltFunc,// Аналитич-я фун-я
                   x; // икс
            int    n; // Счетчик
            Console.WriteLine("Введите х = ");
            x = Convert.ToDouble(Console.ReadLine());
            calcFunc = 2* Math.PI ; anltFunc = Math.PI - x / 2; // Ищем произведение
            if (0 < x && x< Math.PI * 2)
            {
                for (n = 1; n <= 100; n++)
                {
                    calcFunc = calcFunc + Math.Sin(n * x) / n;
                }
                Console.WriteLine("Результат фун-и = " + calcFunc);
                Console.WriteLine("Аналилическая фун-я = " + anltFunc); // Проверка на совпадение
                if (Math.Abs(calcFunc - anltFunc) < 0.1)
                {
                    Console.WriteLine("Расчет верен");
                }
                else
                {
                    Console.WriteLine("Расчет неверен");
                }
            }
            else
            {
                Console.WriteLine("Введенное число х некорректно ");

            }
            Console.ReadKey(); // Просто пауза
        }    
    }
}
