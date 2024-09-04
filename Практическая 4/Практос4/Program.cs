using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практос4
{
    class Program
    {
        static void Main(string[] args)
        {
            int day;//какой день
            Console.WriteLine("Сколько дней в вашем месяце");
            day = Convert.ToInt32(Console.ReadLine());//вводим день
            switch(day)
            {
                case 28: case 29://ввели дни февраля
                    Console.WriteLine("Февраль");
                    break;
                case 30:// сколько дней в апреле июне сентябре и ноябре
                    Console.WriteLine("Апрель " + "Июнь " + "Сентябрь " + "Ноябрь ");
                    break;
                case 31://сколько дней в январе марте мае июле августе октябре декабре
                    Console.WriteLine("Январб " + "Март " + "Май " + "Июль " + "Август " + "Октябрь " + "Декабрь ");
                    break;
            }
            Console.ReadKey();// паузная пауза
        }
    }
}
