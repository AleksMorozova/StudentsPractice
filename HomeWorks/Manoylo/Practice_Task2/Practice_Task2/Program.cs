using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("\nTask1");
            Console.Write("Введите число -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + i * n);
            }

            // 2
            Console.WriteLine("\nTask2");
            Console.Write("Введите число -> ");
            int x = Convert.ToInt32(Console.ReadLine());
            int digit = 0;
            while (x != 0)
            {
                digit++;
                x /= 10;
            }
            Console.WriteLine("Digit: " + digit);

            // 3
            Console.WriteLine("\nTask3");
            Random rn = new Random();
            int key = rn.Next(1, 146);
            Console.Write("Введите число [1; 146] -> ");
            int t = Convert.ToInt32(Console.ReadLine());
            while (t != key)
            {
                if (t < key)
                {
                    Console.WriteLine("Больше!");
                }
                else if (t > key)
                {
                    Console.WriteLine("Меньше!");
                }
                Console.Write("Введите число [1; 146] -> ");
                t = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ура!");

            // 4
            Console.WriteLine("\nTask4");
            Console.Write("Введите число -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; ; i++)
            {
                if (i * i < num)
                    Console.WriteLine(i * i);
                else break;
            }

            // 5
            Console.WriteLine("\nTask5");
            double average = 0;
            double number = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Введите число -> ");
                number = Convert.ToDouble(Console.ReadLine());
                average += number / 5;
            }
            Console.WriteLine("Среднее: " + average);

            // 6
            Console.WriteLine("\nTask6");
            double aver = 0;
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                aver += rd.Next(1, 100) / 5;
            }
            Console.WriteLine("Среднее: " + aver);

            // 7
            Console.WriteLine("\nTask7");
            for (int i = 4; i <= 60; i += 4)
            {
                Console.Write("Кролики: " + i / 4);
                Console.WriteLine("\tГуси: " + (64 - i) / 2);
            }

            // 8 
            Console.WriteLine("\nTask8");
            Console.Write("Введите пароль -> ");
            string password = Convert.ToString(Console.ReadLine());
            while (password != "root")
            {
                Console.Write("Введите пароль -> ");
                password = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Правильный пароль!");
            Console.ReadKey();
        }
    }
}
