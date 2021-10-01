using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Lab4
    {
        enum Days
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        enum Karts
        {
            six = 6,
            seven,
            eight,
            nine,
            ten,
            jack,
            queen,
            king,
            ace
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1");
            Console.WriteLine("\nПеревертыши ");
            Console.WriteLine("Введите трехзначное число");
            int abc = Convert.ToInt32(Console.ReadLine());
            int a = abc / 100;
            int c = abc % 10;
            Console.WriteLine("\nОтвет:");
            if (a == c)
            {

                Console.WriteLine(abc + " - палиндром");
            }
            else
            {

                Console.WriteLine(abc + " - не палиндром");
            }


            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nВходит и выходит ");
            Console.WriteLine("Введите сторону");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы");
            double Head = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            if ((Head + 2 <= side1) && (Head + 2 <= side2))
            {
                Console.WriteLine("получится");
            }
            else
            {
                Console.WriteLine("не получится");
            }


            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\n День недели");
            Console.WriteLine("Введите номер дня недели");
            int Day = Convert.ToInt32(Console.ReadLine());
            Days num = (Days)(Day);
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(num);


            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("\nКарты ");
            Console.WriteLine("Введите номер карты");
            while (true)
            {
                try
                {
                    int numer = Convert.ToInt32(Console.ReadLine());
                    if (Enum.IsDefined(typeof(Karts), numer))
                    {

                        Karts kart = (Karts)numer;
                        Console.WriteLine("\nОтвет:");
                        Console.WriteLine(kart);
                        break;
                    }
                    else
                    {
                        throw new Exception();
                    }

                }
                catch
                {
                    Console.WriteLine("Вы ввели неправильное число. Введите новое");
                }
            }

            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Расстояние до линии горизонта");
            int height = 1;
            int rad = 6370;
            Console.WriteLine("\nОтвет:");
            while (height < 11)
            {
                double heightrad = (rad + height) * (rad + height) - (rad * rad);
                double horizonte = Math.Sqrt(heightrad);
                Console.WriteLine($"{horizonte} - {height} km");
                height++;
            }

            Console.WriteLine("\nЗадание 6");
            Console.WriteLine("Таблица умножения");
            int count = 1;
            Console.WriteLine("Введите число");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            while (count < 10)
            {
                int anser = number * count;
                Console.WriteLine($"{number} * {count} = {anser}");
                count++;
            }







            Console.WriteLine("\nЗадание 7");
            Console.WriteLine("\nПоследовательность");
            Console.WriteLine("Введите последовательность ");
            count = 0;
            int cred = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                while (number > 0)
                {
                    cred = cred + number;

                    number = Convert.ToInt32(Console.ReadLine());

                    count++;
                }

                throw new Exception();

            }

            catch
            {
                double anser = (cred / count);
                Console.WriteLine("\nОтвет:");
                Console.WriteLine(anser);
            }



            Console.WriteLine("\nЗадание 8");
            Console.WriteLine("\nПоследовательность");
            Console.WriteLine("Введите последовательность ");
            int []array = new int [10];
            
            for (int i = 0; i < array.Length ; i++)
            {
               array [i] = Convert.ToInt32(Console.ReadLine());  
            
            
          }
            Console.WriteLine("\nОтвет:");
            for (int i = 1; i < array.Length  ; i++) {
                if (array[i-1] > array[i]) {
                    Console.WriteLine(array[i]);
                    break;
                }
               else 
                {
                    if (i == array.Length -1  ) { 
                  
                        Console.WriteLine("эта последовательность упорядоченнa по возрастанию.");
                    }
                }
            }

            Console.WriteLine("\nЗадание 9");
            Console.WriteLine("\nПоследовательность");
            Console.WriteLine("Введите последовательность ");
            int newel = 1;
            int sum = 0;
            int n = 0;
            while (newel != 0)
            {
                newel = int.Parse(Console.ReadLine());
                n = n + 1;
                if (n % 3 != 0)
                    continue;
                sum = sum + newel;
            }
            Console.WriteLine(sum);


            Console.WriteLine("\nЗадание 10");
            Console.WriteLine("\nПоследовательность");
            Console.WriteLine("Введите последовательность ");
            sum = 0;
            count = 1;
            while (true)
            {
                number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    goto switchend;
                }
               else if (count % 3 == 0)
                {
                  sum =  sum + number;
                }
                count++;
            }
        switchend:
            {
                Console.WriteLine(sum);
            }
        














        Console.ReadKey();
        }
    }
}

