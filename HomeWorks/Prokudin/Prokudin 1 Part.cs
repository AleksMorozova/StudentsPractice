using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace _0-_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"|{"Prokudin",8} {"Georgiy",10} {"Vladimirovich",15}|");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1-_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter first number:");
//            var firstNum = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter second number:");
//            var secondNum = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Biggest number is: ");
//            if (firstNum > secondNum)
//            {
//                Console.WriteLine($"{firstNum}");
//            }
//            else
//            {
//                Console.WriteLine($"{secondNum}");
//            }

//            Console.ReadKey();

//        }
//    }
//}

//namespace _1-_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the phrase:");
//            var phrase = Console.ReadLine();
//            if (phrase != "meow" && phrase != "bark")
//            {
//                Console.WriteLine("Unknown command.");
//            }
//            else
//            {
//                Console.WriteLine(phrase == "meow" ? "Feed the cat!" : "Walk out the dog!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1-_3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            while (true)
//            {
//                ShowDialog();
//            }
//        }

//        private static void ShowDialog()
//        {
//            Console.WriteLine("Введите номер месяца:");
//            var mounthNum = Convert.ToInt16(Console.ReadLine());
//            if (mounthNum < 1 || mounthNum > 12)
//            {
//                Console.WriteLine("На этой планете такого месяца нет.");
//            }
//            else if (mounthNum >= 6 && mounthNum < 9)
//            {
//                Console.WriteLine("Лето");
//            }
//            else if (mounthNum >= 9 && mounthNum < 12)
//            {
//                Console.WriteLine("Осень");
//            }
//            else if (mounthNum == 1 || mounthNum == 12 || mounthNum == 2)
//            {
//                Console.WriteLine("Зима");
//            }
//            else if (mounthNum > 2 && mounthNum < 6)
//            {
//                Console.WriteLine("Весна");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1-_4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number:");
//            var number = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine(number == 1 ? "Good!" : number == 0 ? "Bad!" : "null");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1-_5
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            var days = new List<string>();
//            days.Add("Sunday");
//            days.Add("Monday");
//            days.Add("Tuesday");
//            days.Add("Wednesday");
//            days.Add("Thursday");
//            days.Add("Friday");
//            days.Add("Saturday");
//            while (true)
//            {
//                Console.WriteLine("Enter day's position in the week: ");
//                var number = Convert.ToInt32(Console.ReadLine());
//                try
//                {
//                    Console.WriteLine(days[number]);
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("No such day");
//                }

//            }
//        }
//    }
//}

//namespace _1-_6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter trip length: ");
//            var tripLength = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter waiting length: ");
//            var waitingLength = Convert.ToInt32(Console.ReadLine());
//            int cost = waitingLength;
//            for (int i = 0; i < tripLength; i++)
//            {
//                if (i < 5)
//                {
//                    cost += 20;
//                }
//                else
//                {
//                    cost += 3;
//                }
//            }
//            Console.WriteLine($"Trip cost: {cost}");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1-_7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter natural number:");
//            var natNumber = Convert.ToInt32(Console.ReadLine());
//            bool flag = false;
//            for (int i = 2; i < natNumber; i++)
//            {
//                if (natNumber % i == 0)
//                {
//                    flag = true;
//                }
//            }
//            if (!flag)
//            {
//                Console.WriteLine("The number is simple");
//            }
//            else
//            {
//                Console.WriteLine("The number isn't simple!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1-_8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var random = new Random();
//            var res = random.Next(1, 12);
//            Console.WriteLine("Enter the wager:");
//            int swager = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"The number on cube:{res}");
//            if (res >= 1 && res <= 5)
//            {
//                Console.WriteLine("You lose!");
//            }
//            if (res >= 6 && res <= 8)
//            {
//                swager -= swager;
//                Console.WriteLine($"You win {swager}!");
//            }
//            if (res >= 9 && res <= 11)
//            {
//                swager += swager;
//                Console.WriteLine($"You win {swager}!");
//            }
//            if (res == 12)
//            {
//                swager = 10 * swager;
//                Console.WriteLine($"You win {swager}!");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace _1-_9
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//                Console.WriteLine("Enter number:");
//                double number = Convert.ToDouble(Console.ReadLine());
//                int temp1 = 0;
//                Console.WriteLine("1-grn\n2-dollar\n3-euro");
//                Console.WriteLine("Enter currency number:");
//                int temp = Convert.ToInt32(Console.ReadLine());
//                if (temp == 1)
//                {
//                    Console.WriteLine("Enter transfer currency number:");
//                    temp1 = Convert.ToInt32(Console.ReadLine());
//                    switch (temp1)
//                    {
//                        case 1: Console.WriteLine(number / 1); break;
//                        case 2: Console.WriteLine(number / 25.15); break;
//                        case 3: Console.WriteLine(number / 28.4); break;
//                    }
//                }
//                if (temp == 2)
//                {
//                    Console.WriteLine("Enter transfer currency number:");
//                    temp1 = Convert.ToInt32(Console.ReadLine());
//                    switch (temp1)
//                    {
//                        case 1: Console.WriteLine(number * 25.38); break;
//                        case 2: Console.WriteLine(number * 1); break;
//                        case 3: Console.WriteLine(number * 28.7); break;
//                    }
//                }
//                if (temp == 3)
//                {
//                    Console.WriteLine("Enter transfer currency number:");
//                    temp1 = Convert.ToInt32(Console.ReadLine());
//                    switch (temp1)
//                    {
//                        case 1: Console.WriteLine(number * 28.4); break;
//                        case 2: Console.WriteLine(number * 28.74); break;
//                        case 3: Console.WriteLine(number * 1); break;
//                    }
//                }
//        }
//    }
//}


