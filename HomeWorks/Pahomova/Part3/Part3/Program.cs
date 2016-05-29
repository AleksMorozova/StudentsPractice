using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1
            Console.WriteLine("\nEx1");
            Console.Write("Enter the number -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + i * n);
            }

            // 2
            Console.WriteLine("\nEx2");
            Console.Write("Enter the number -> ");
            int x = Convert.ToInt32(Console.ReadLine());
            int digit = 0;
            while (x != 0)
            {
                digit++;
                x /= 10;
            }
            Console.WriteLine("Digit: " + digit);

            // 3
            Console.WriteLine("\nEx3");
            Random rn = new Random();
            int key = rn.Next(1, 146);
            Console.Write("Enter the number [1; 146] -> ");
            int t = Convert.ToInt32(Console.ReadLine());
            while (t != key)
            {
                if (t < key)
                {
                    Console.WriteLine("Larger!");
                }
                else if (t > key)
                {
                    Console.WriteLine("Smaller!");
                }
                Console.Write("Enter the number [1; 146] -> ");
                t = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You guessed!");

            // 4
            Console.WriteLine("\nEx4");
            Console.Write("Enter the number -> ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; ; i++)
            {
                if (i * i < num)
                    Console.WriteLine(i * i);
                else break;
            }

            // 5
            Console.WriteLine("\nEx5");
            double average = 0;
            double number = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter the number -> ");
                number = Convert.ToDouble(Console.ReadLine());
                average += number / 5;
            }
            Console.WriteLine("Average: " + average);

            // 6
            Console.WriteLine("\nEx6");
            double aver = 0;
            Random rd = new Random();
            for (int i = 0; i < 5; i++)
            {
                aver += rd.Next(1, 100)/5;
            }
            Console.WriteLine("Average: " + aver);

            // 7
            Console.WriteLine("\nEx7");
            for (int i = 4; i <= 60; i += 4)
            {
                Console.Write("Rabbits: " + i / 4);
                Console.WriteLine("\tGeese: " + (64 - i) / 2);
            }

            // 8 
            Console.WriteLine("\nEx8");
            Console.Write("Enter the password -> ");
            string password = Convert.ToString(Console.ReadLine());
            while (password != "root")
            {
                Console.Write("Enter the password -> ");
                password = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("The correct password!");
            Console.ReadKey();
        }
    }
}
