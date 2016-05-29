using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("+-----------------------+");
            Console.WriteLine("|Пахомова Елена Олеговна|");
            Console.WriteLine("+-----------------------+");
            Console.ReadKey();


            // 1
            Console.WriteLine("\nEx1");
            Console.Write("Enter first number -> ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number -> ");
            double second = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Max: {0}", (first > second) ? first : second);
            

            // 2
            Console.WriteLine("\nEx2");
            Console.Write("Pet -> ");
            string phrase = Convert.ToString(Console.ReadLine());
            Console.WriteLine(phrase.Equals("мяу")? "Покорми кота!" : phrase.Equals("гав") ? "Погуляй с собакой!" : "Неизвестное животное!");
            

            // 3
            Console.WriteLine("\nEx3");
            Console.Write("Enter month number -> ");
            int month = Convert.ToInt32(Console.ReadLine());
            
            if (month < 3 || month == 12) 
                Console.WriteLine("Winter");
            else if (month > 2 && month < 6)
                Console.WriteLine("Spring");
            else if (month > 5 && month < 9)
                Console.WriteLine("Summer");
            else if (month > 8 && month < 12)
                Console.WriteLine("Autumn");
            else
                Console.WriteLine("There is no such month on this planet!");
            

            // 4
            Console.WriteLine("\nEx4");
            Console.Write("[0, 1] -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n == 0)? "Bad!" : (n == 1) ? "Good!" : "Error!");
            

            // 5
            Console.WriteLine("\nEx5");
            Console.Write("Enter day number -> ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;

            }
             

            // 6
            Console.WriteLine("\nEx6");
            Console.Write("Enter kilometers -> ");
            double kilometers =  Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of minutes of inactivity -> ");
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
            Console.WriteLine("Price: " + price + " UAN");
            

            // 7
            Console.WriteLine("\nEx7");
            int number;
            bool isComplex = false;
            Console.Write("Enter number -> ");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isComplex = true;
                    break;
                }
            }
            if (isComplex) Console.WriteLine("Number is complex!");
            else Console.WriteLine("Number is simple!");
             

            // 8
            Console.WriteLine("\nEx8");
            Console.Write("Enter bet -> ");
            int bet = Convert.ToInt32(Console.ReadLine());
            int prize = 0;
            Random rand = new Random();
            int points = rand.Next(1,12);
            Console.WriteLine("Points: " + points);
            if (points >= 1 && points <= 5)
                prize = 0;
            else if (points >= 6 && points <= 8)
                prize = bet;
            else if (points >= 9 && points <= 11)
                prize = 2 * bet;
            else if (points == 12)
                prize = 10 * bet;
            
            Console.WriteLine("Your prize is " + prize + "!");
             

            // 9
            Console.WriteLine("\nEx9");
            Console.Write("Enter sum -> ");
            double sum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter currency -> \n 1. $ \n 2. euro \n 3. UAN");
            int currency = Convert.ToInt32(Console.ReadLine());
            switch (currency)
            {
                case 1:
                    Console.WriteLine("{0:#0.00} UAN", sum*24.92);
                    Console.WriteLine("{0:#0.00} euro", sum*0.88);
                    break;
                case 2:
                    Console.WriteLine("{0:#0.00} UAN", sum*27.62);
                    Console.WriteLine("{0:#0.00} $", sum*1.09);
                    break;
                case 3:
                    Console.WriteLine("{0:#0.00} $", sum/24.92);
                    Console.WriteLine("{0:#0.00} euro", sum/28.26);
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
