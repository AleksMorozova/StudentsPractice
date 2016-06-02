using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask0");
            Console.WriteLine("+---------------------------+");
            Console.WriteLine("|Манойло Роман Александрович|");
            Console.WriteLine("+---------------------------+");
            Console.ReadKey();


            // 1
            Console.WriteLine("\nTask1");
            double a, b;
            Console.WriteLine("Введите 2 числа");
            Console.Write("a -> ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b -> ");
            b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + ">" + b + " -> a>b");
                Console.ReadKey();
            }
            if (a < b)
            {
                Console.WriteLine(a + "<" + b + " -> a<b");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
            }


            // 2
            Console.WriteLine("\nTask2");
            string str;
            Console.Write("Введите слово (мяу/гав) -> ");
            str = Console.ReadLine();
            if (str == "мяу")
            {
                Console.WriteLine("Покорми кота");
                Console.ReadKey();
            }
            if (str == "гав")
            {
                Console.WriteLine("Погуляй с собакой");
                Console.ReadKey();
            }
            if ((str != "мяу") && (str != "гав"))
            {
                Console.WriteLine("Ошибка");
                Console.ReadKey();
            }

            // 3
            Console.WriteLine("\nTask3");
            Console.Write("Номер месяца -> ");
            int month = Convert.ToInt32(Console.ReadLine());

            if (month < 3 || month == 12)
                Console.WriteLine("Зима");
            else 
                if (month > 2 && month < 6)
                Console.WriteLine("Весна");
            else 
                if (month > 5 && month < 9)
                Console.WriteLine("Лето");
            else 
                if (month > 8 && month < 12)
                Console.WriteLine("Осень");
            else
                Console.WriteLine("На этой планете такого месяца нет");


            // 4
            Console.WriteLine("\nTask4");
            Console.Write("Введите число [0, 1] -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n == 0) ? "Плохо!" : (n == 1) ? "Хорошо!" : "Ошибка!");


            // 5
            Console.WriteLine("\nTask5");
            Console.Write("Введите день недели -> ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Понидельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Субота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;

            }


            // 6
            Console.WriteLine("\nTask6");
            Console.Write("Введите километры -> ");
            double kilometers = Convert.ToDouble(Console.ReadLine());
            Console.Write("Минуты простоя -> ");
            double minutes = Convert.ToDouble(Console.ReadLine());
            double price = 0;

            if (kilometers <= 5)
            {
                price = kilometers * 20;
                price += minutes;
            }
            else
            {
                price = 5 * 20;
                kilometers -= 5;
                double g = kilometers * 3;
                price += g;
                price += minutes;
            }
            Console.WriteLine("Цена: " + price + " грн");


            // 7
            Console.WriteLine("\nTask7");
            int num;
            Console.Write("Введите число-> ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 2)
            {
                Console.WriteLine("Число не простое");
                Console.ReadKey();
            }

            else
            {
                bool prime = true;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }
                Console.ReadKey();
            }

            // 8
            Console.WriteLine("\nTask8");
            Console.Write("Введите ставку -> ");
            int bet = Convert.ToInt32(Console.ReadLine());
            int prize = 0;
            Random rand = new Random();
            int points = rand.Next(1, 12);
            Console.WriteLine("Очки" + points);
            if (points >= 1 && points <= 5)
                prize = 0;
              else 
                if (points >= 6 && points <= 8)
                    prize = bet;
                 else 
                    if (points >= 9 && points <= 11)
                       prize = 2 * bet;
                     else 
                        if (points == 12)
                       prize = 10 * bet;

            Console.WriteLine("Выиграш" + prize + "!");


            // 9
            Console.WriteLine("\nTask9");
            Console.Write("Введите сумму-> ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Валюта: -> \n 1. $ \n 2. euro \n 3. UAN");
            int currency = Convert.ToInt32(Console.ReadLine());
            switch (currency)
            {
                case 1:
                    Console.WriteLine("{0:#0.00} UAN", sum * 26.2);
                    Console.WriteLine("{0:#0.00} euro", sum * 0.75);
                    break;
                case 2:
                    Console.WriteLine("{0:#0.00} UAN", sum * 28.7);
                    Console.WriteLine("{0:#0.00} $", sum * 1.05);
                    break;
                case 3:
                    Console.WriteLine("{0:#0.00} $", sum / 25.5);
                    Console.WriteLine("{0:#0.00} euro", sum / 27.8);
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
