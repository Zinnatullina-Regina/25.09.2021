using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nЗадание 1");
            Console.WriteLine("\nВведите число");
            int day = Convert.ToInt32(Console.ReadLine());
           
                int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int sum = 0;
                int i = 0;
            while (sum < day)
            {
                sum += months[i++];
            }
                sum -= months[--i];
                sum = day - sum;
            Console.WriteLine("\nОтвет:");
            Console.WriteLine("{0} день - это {2}день {3} месяца", day, sum, i + 1);





            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nВведите число");
             day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            if (day >= 1 && day <= 365)
            {
                int[] months2 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                sum = 0;
                i = 0;
                while (sum < day)
                {
                    sum += months2[i++];
                }
                sum -= months2[--i];
                sum = day - sum;
                Console.WriteLine("{0} день - это {2}день {3} месяца", day, sum, i + 1);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");
            }



            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\nВведите число");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            bool yearv = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            if (day >= 1 && day <= ((yearv == true) ? 366 : 365))
            {
                int[] months3 = { 31, (yearv == true) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                sum = 0;
                i = 0;
                while (sum < day)
                {
                    sum += months3[i++];
                }
                sum -= months3[--i];
                sum = day - sum;
                Console.WriteLine("{0} день - это {2}день {3} месяца", day, sum, i + 1);
            }
            else
            {
                Console.WriteLine("Ошибка ввода данных");

            }






            Console.ReadKey();
        }
    }
}