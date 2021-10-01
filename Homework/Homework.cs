using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Homework
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nЧасть 1\nЗадание 1");
            Console.WriteLine("\nВведите число");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            if (number < 0)
            {
                number = number * (-1);
            }
            Console.WriteLine(number);

            Console.WriteLine("Задание 2");
            Console.WriteLine("\nВведите 1 число");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nВведите 2 число");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            if (number < 0)
            {
                number = number * (-1);
            }
            if (number2 < 0)
            {
                number2 = number2 * (-1);
            }
            if (number > number2)
            {
                number = number / 2;

            }
            Console.WriteLine(number + " 1 число");
            Console.WriteLine(number2 + " 2 число");


            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\nВведите животное");
            string animal = Console.ReadLine();
            string alligator = "аллигатор";
            string mouth;
            if (animal.Equals(alligator))
            {
                mouth = "small ";
            }
            else
            {
                mouth = "big ";
            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(mouth);




            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Введите строку");
            string zakaz = Console.ReadLine();
            zakaz.ToLower();
            Console.WriteLine("\nОтвет:");
            switch (zakaz)
            {
                case "jabroni":
                    Console.WriteLine("Patron Tequlla");
                    break;
                case "school counsellor":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("Введите строку");
            string s1 = Console.ReadLine();
            string s2 = "english";
            string answer;
            s1.ToLower();
            int i = 0, x = -1;
            while (i != -1)
            {
                i = s1.IndexOf(s2, x + 1);
                x = i;
            }
            if (i == -1)
            {
                answer = "no";
            }
            else
            {
                answer = "yes";
            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(answer);



            Console.WriteLine("\nЧасть 2\nЗадание 1");
            double three = 3;
            int n = 1;
            number = 1;
            while (n < 9)
            {
                number = number + (1 / three);

                three = three * 3;
                n++;
            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(number);



            Console.WriteLine("\nЗадание 2");
            number = 1;
            int count = 1;
            double home = 0;
            double work = 1;
            for (double r = 2; r < 101; r++)
            {
                
                number = number + (1 / r);
               

                if (count % 2 != 0)
                {
                    home = home + (1 / r);
                }
                else
                {
                    work = work + (1 / r);

                }
                count++;

            }

            Console.WriteLine("\nОтвет:");
            Console.WriteLine(number);
            Console.WriteLine(work - home);



            Console.WriteLine("\nЗадание 3");
            Random rand = new Random();
            int[] osadkij = new int[31];
            int[] osadkim = new int[31];
            int credjan = 0;
            int credmart = 0;
            for (i = 0; i < osadkij.Length; i++)
            {
                osadkij[i] = rand.Next(0, 50);
                credjan = credjan + osadkij[i];
            }
            for (i = 0; i < osadkim.Length; i++)
            {
                osadkim[i] = rand.Next(0, 50);
                credmart = credmart + osadkim[i];
            }


            Console.WriteLine("\nОтвет:");
            Console.WriteLine(credjan / 31 + " Среднемесячное количество осадков января ");
            Console.WriteLine(credmart / 31 + " Среднемесячное количество осадков марта ");



            Console.WriteLine("\nЧасть 3\nЗадание 1");

            int a = 3;
            int b = 2;
            int c = 1;
            int d = 0;
            while (Math.Abs((double)a / b - (double)b / c) > 0.001)
            {
                d = a;
                a += b;
                c = b;
                b = d;
            }
            Console.WriteLine("Ответ: {0}/{1}", a, b);



            Console.WriteLine("\nЗадание 2");
            Console.WriteLine("\nВведите число");
            double N = Convert.ToDouble(Console.ReadLine());
            int num = 1;
            int dop = 1;
            while (num <= N)
            {
                dop += 2;
                num = num + dop;
            }

            Console.WriteLine("\nОтвет:");
            Console.WriteLine(num);


            Console.WriteLine("\nЗадание 3");
            Console.WriteLine("\nЧасть a");
            a = 100;
            Console.WriteLine("\nОтвет:");
            while (a >= 80)
            {
                Console.WriteLine($"{a}");
                a--;
            }
            Console.WriteLine("\nЧасть b");
            b = 100;
            Console.WriteLine("\nОтвет:");
            do
            {
                Console.WriteLine($"{b}");
                b--;
            } while (b >= 80);



            Console.WriteLine("\nЗадание 4");
            int ans = 0;
            for (num = 0; num <= 5000; num++)
            {
                if (num % 39 == 0)
                {
                    ans = num;
                }

            }
            Console.WriteLine("\nОтвет:");
            Console.WriteLine(ans);




            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("\nЧасть a");
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            n = 1;
            for (int stroki = 1; stroki <= 5; stroki ++  )
            {
                for (int kolvo =1; kolvo <= n; kolvo++) {
                   
                    Console.Write(chislo + " ");
                }
                Console.WriteLine();
                n++;
            }


            Console.WriteLine("\nЗадание 5");
            Console.WriteLine("\nЧасть b");
            chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nОтвет:");
            n = 5;
            for (int stroki = 1; stroki <= 5; stroki++)
            {
                for (int kolvo = n; kolvo >= 1; kolvo--)
                {
                   
                    Console.Write(chislo + " ");
                }
                Console.WriteLine();
                n--;
            }





































            Console.ReadKey();
        }
    }
}
