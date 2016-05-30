//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _0._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var name = "Rostyslav";
//            var lastName = "Kostenko";
//            var middleName = "Andreevich";
//            var fullName = $"| {lastName} {name} {middleName} |";

//            Console.WriteLine($"+{new string('-', fullName.Length - 2)}+");
//            Console.WriteLine(fullName);
//            Console.WriteLine($"+{new string('-', fullName.Length - 2)}+");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter first number:");
//            var firstNum = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Enter second number:");
//            var secondNum = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Bigger number is: ");
//            Console.WriteLine((firstNum > secondNum) ? firstNum : secondNum);
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the phrase:");
//            var phrase = Console.ReadLine();
//            if (phrase != "meow" && phrase != "bark")
//            {
//                Console.WriteLine("Entered phrase is unhandled.");
//            }
//            else
//            {
//                Console.WriteLine(phrase == "meow" ? "Feed the cat!" : "Walk out the dog!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Enter the mounth number:");
//            var mounthNum = Convert.ToInt16(Console.ReadLine());

//            if (mounthNum < 1 || mounthNum > 12)
//            {
//                Console.WriteLine("There is no such season at this planet");
//            }
//            else if (mounthNum == 1 || mounthNum == 2 || mounthNum == 12)
//            {
//                Console.WriteLine("It's Winter!");
//            }
//            else if (mounthNum > 2 && mounthNum < 6)
//            {
//                Console.WriteLine("It's Spring!");
//            }
//            else if (mounthNum > 5 && mounthNum < 9)
//            {
//                Console.WriteLine("It's Summer!");
//            }
//            else if (mounthNum > 8 && mounthNum < 12)
//            {
//                Console.WriteLine("It's Autumn!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number:");
//            var number = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine(number == 1 ? "Good!" : number == 0 ? "Bad!" : "NULL");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var daysOfAWeek = new List<string>();
//            daysOfAWeek.Add("Sunday");
//            daysOfAWeek.Add("Monday");
//            daysOfAWeek.Add("Tuesday");
//            daysOfAWeek.Add("Wednesday");
//            daysOfAWeek.Add("Thursday");
//            daysOfAWeek.Add("Friday");
//            daysOfAWeek.Add("Saturday");
//            while (true)
//            {
//                Console.WriteLine("Enter the day's position in a week: ");
//                var number = Convert.ToInt32(Console.ReadLine());
//                try
//                {
//                    Console.WriteLine(daysOfAWeek[number]);
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("There's no such day in a week");
//                }

//            }
//        }
//    }
//}

//namespace _1._6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a trip length: ");
//            var tripLength = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter a waiting length: ");
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

//namespace _1._7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter natural number:");
//            var natNumber = Convert.ToInt32(Console.ReadLine());
//            var flag = false;
//            for (int i = 2; i < natNumber; i++)
//            {
//                if (natNumber % i == 0)
//                {
//                    flag = true;
//                }
//            }
//          
//            Console.WriteLine(flag ? "The number isn't prime!" :  "The number is prime");          
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var random = new Random();
//            int res = random.Next(1, 12);
//            Console.WriteLine("Enter the wager:");
//            int wager = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"The number on the cube:{res}");
//            if (res >= 1 && res <= 5)
//            {
//                Console.WriteLine("You lose!");
//            }
//            if (res >= 6 && res <= 8)
//            {
//                wager -= wager;
//                Console.WriteLine($"You win {wager}!");
//            }
//            if (res >= 9 && res <= 11)
//            {
//                wager += wager;
//                Console.WriteLine($"You win {wager}!");
//            }
//            if (res == 12)
//            {
//                wager = 10 * wager;
//                Console.WriteLine($"You win {wager}!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _1._9
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the amount of money to exchange: ");
//            double moneyQuantity = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("[1: UAH; 2: USD; 3: EUR]");
//            Console.WriteLine("Choose the currency (1-3): ");
//            int currencyNumber = Convert.ToInt32(Console.ReadLine());

//            if (currencyNumber == 1)
//            {
//                Console.WriteLine($"It equals USD {moneyQuantity * 0.04} or EUR {moneyQuantity * 0.03}");
//            }
//            if (currencyNumber == 2)
//            {
//                Console.WriteLine($"It equals UAH {moneyQuantity * 25.1} or EUR {moneyQuantity * 0.89}");
//            }
//            if (currencyNumber == 3)
//            {
//                Console.WriteLine($"It equals UAH {moneyQuantity * 28.4} or USD {moneyQuantity * 1.12}");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number:");
//            double n = Convert.ToDouble(Console.ReadLine());
//            for (int i = 0; i <= 20; i++)
//            {
//                Console.WriteLine($"{n} * {i,2} = {n * i}");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number:");
//            int number = Convert.ToInt32(Console.ReadLine());
//            int i = 0;
//            while (number > 1)
//            {
//                number = number / 10;
//                i++;
//            }
//            Console.WriteLine($"The answer is {i}");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int randomNumber = new Random().Next(1, 146);
//            while (true)
//            {
//                Console.WriteLine("Enter number:");
//                int number = Convert.ToInt32(Console.ReadLine());

//                if (number < randomNumber)
//                    Console.WriteLine("Try to enter a bigger number.");

//                if (number > randomNumber)
//                    Console.WriteLine("Try to enter a smaller number.");

//                if (number == randomNumber)
//                { Console.WriteLine("You're right!"); break; }

//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number:");
//            int number = Convert.ToInt32(Console.ReadLine());

//            int i = 1;
//            while (Math.Pow(i, 2) <= number)
//            {
//                Console.WriteLine($"[{i}^2]: {Math.Pow(i, 2)}");
//                i++;
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[5];
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.WriteLine("Enter number:");
//                numbers[i] = Convert.ToInt32(Console.ReadLine());
//            }

//            Console.WriteLine($"The average of entered numbers ({numbers.Sum()}/{numbers.Length}) is {Convert.ToDouble(numbers.Sum()) / Convert.ToDouble(numbers.Length)}");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._6
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] numbers = new int[5];
//            var randomNumber = new Random();
//            Console.WriteLine("Generated numbers: ");
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                numbers[i] = randomNumber.Next(1, 1000);
//                Console.WriteLine($"{i + 1}) {numbers[i]}");
//            }

//            Console.WriteLine($"The average of entered numbers ({numbers.Sum()}/{numbers.Length}) is {Convert.ToDouble(numbers.Sum()) / Convert.ToDouble(numbers.Length)}");
//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Rabbits usually have 4 feet. Geese usually have 2 feet.\n All combinations of animals are displayed down below.");

//            for (int i = 1; i < 16; i++)
//            {
//                Console.WriteLine($"The {i,2} rabbits and {(64 - (4 * i)) / 2,2} geese have 64 feet in total.");
//            }

//            Console.ReadKey();
//        }
//    }
//}

//namespace _2._8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string password = "root";
//            while (true)
//            {
//                Console.WriteLine("Enter the password: ");
//                if (Console.ReadLine() == password)
//                {
//                    Console.WriteLine("Password is correct.");
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Entered password is incorrect! Try again.");
//                    Console.ReadKey();
//                    Console.Clear();
//                }
//            }
//            Console.ReadKey();
//        }
//    }
//}

