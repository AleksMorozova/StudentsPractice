using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _0._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("+-------------------------------+");
//            Console.WriteLine("  Prostyak   Mariya    Yrievna    ");
//            Console.WriteLine("+-------------------------------+");
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите первое число:");
//            var firstNum = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            var secondNum = Convert.ToDouble(Console.ReadLine());
//            if (firstNum > secondNum)
//            {
//                  Console.WriteLine(firstNum.ToString() +" больше чем " + secondNum.ToString());
//            }
//            else
//            {
//                  Console.WriteLine(secondNum.ToString() +" больше чем " + firstNum.ToString());
//            }
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите слово "мяу" или "гав":");
//            var phrase = Console.ReadLine();
//            if (phrase != "мяу" && phrase != "гав")
//            {
//                Console.WriteLine("Слово введено не правильно");
//            }
//            else
//            {
//                Console.WriteLine(phrase == "мяу" ? "Покорми кота!" : "Выгуляй собаку!");
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
//            while (true)
//            {
//                Month();
//            }
//        }

//        private static void Month()
//        {
//            Console.WriteLine("Введите номер месяца:");
//            var monthNum = Convert.ToInt16(Console.ReadLine());
//            if (monthNum < 1 || monthNum > 12)
//            {
//                Console.WriteLine("На этой планете такого месяца нет.");

//            }
//            else if (monthNum == 1 || monthNum == 12 || monthNum == 2)
//            {
//                Console.WriteLine("Зима");
//            }
//            else if (monthNum > 2 && monthNum < 6)
//            {
//                Console.WriteLine("Весна");
//            }
//            else if (monthNum >= 6 && monthNum < 9)
//            {
//                Console.WriteLine("Лето");
//            }
//            else if (monthNum >= 9 && monthNum < 12)
//            {
//                Console.WriteLine("Осень");
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите число:");
//            var number = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine(number == 1 ? "Хорошо!" : number == 0 ? "Плохо!" : "NULL");
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            var daysOfAWeek = new List<string>();
//            daysOfAWeek.Add("Понедельник");
//            daysOfAWeek.Add("Вторник");
//            daysOfAWeek.Add("Среда");
//            daysOfAWeek.Add("Четверг");
//            daysOfAWeek.Add("Пятница");
//            daysOfAWeek.Add("Суббота");
//            daysOfAWeek.Add("Воскресенье");
//            while (true)
//            {
//                Console.WriteLine("Введите номер дня недели: ");
//                int num = Convert.ToInt16(Console.ReadLine());
//                try
//                {
//                    Console.WriteLine(daysOfAWeek[number]);
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("В неделе такого дня нет:(");
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите длительность поездки: ");
//            var tripLength = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Введите ожидаемую длительность поездки: ");
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
//            Console.WriteLine($"Стоимость тура: {cost}");
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите натуральное число:");
//            int nat = Convert.ToInt32(Console.ReadLine());
//            bool flag = false;
//            for (int i = 2; i < nat; i++)
//            {
//                if (nat % i == 0)
//                {
//                    flag = true;
//                }
//            }
//            if (!flag)
//            {
//                Console.WriteLine("Это простое число");
//            }
//            else
//            {
//                Console.WriteLine("Это не простое число");
//            }
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
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            var random = new Random();
//            var res = random.Next(1, 12);
//            Console.WriteLine("Введите вашу ставку(число):");
//            int wager = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine($"Число на кубике:{res}");
//            if (res >= 1 && res <= 5)
//            {
//                Console.WriteLine("Вы проиграли!");
//            }
//            if (res >= 6 && res <= 8)
//            {
//                wager -= wager;
//                Console.WriteLine($"Вы победили {wager}!");
//            }
//            if (res >= 9 && res <= 11)
//            {
//                wager += wager;
//                Console.WriteLine($"Вы победили {wager}!");
//            }
//            if (res == 12)
//            {
//                wager = 10 * wager;
//                Console.WriteLine($"Вы победили {wager}!");
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

//namespace _2._1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            string n;
//            Console.WriteLine("Введите число:");
//            n = Console.ReadLine();
//            for (int i = 0; i < 21; i++)
//            {
//                Console.WriteLine(n + "*" + i + "=" + Convert.ToInt32(n) * i);
//            }
//        }
//    }
//}


//namespace _2._2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            string n;
//            Console.WriteLine("Введите число:");
//            n = Console.ReadLine();
//            int nn = Convert.ToInt32(n);
//            int i = 0;
//            nn = Convert.ToInt32(n);
//            for (; nn != 0; i++)
//            {
//                nn = nn / 10;
//            }
//            Console.WriteLine(i);
//        }
//    }
//}
//namespace _2._3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Random rand = new Random();
//            int temp;
//            temp = rand.Next(0,147);
//            string n;
//            for (; ; )
//            {
//                Console.WriteLine("Введите число:");
//                n = Console.ReadLine();
//                if (Convert.ToInt32(n) > temp)
//                {
//                    Console.WriteLine("Меньше");
//                }
//                if (Convert.ToInt32(n) < temp)
//                {
//                    Console.WriteLine("Больше");
//                }
//                if (Convert.ToInt32(n) == temp)
//                {
//                    Console.WriteLine("Вы угадали!!!");
//                    return;
//                }
//            }
//        }
//    }
//}
//namespace _2._4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите число:");
//            int temp = Convert.ToInt32(Console.ReadLine());
//            int kvad = 0;

//            for (int i = 1; ; i++)
//            {
//                kvad = i * i;

//                if (kvad >= temp)
//                {
//                    return;
//                }
//                Console.WriteLine(kvad);
//            }
//        }
//    }
//}
//namespace _2._5
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Введите число 1:");
//            string s = Console.ReadLine();
//            int a = int.Parse(s);
//            Console.WriteLine("Введите число 2:");
//            string s1 = Console.ReadLine();
//            int b = int.Parse(s1);
//            Console.WriteLine("Введите число 3:");
//            string s2 = Console.ReadLine();
//            int c = int.Parse(s2);
//            Console.WriteLine("Введите число 4:");
//            string s3 = Console.ReadLine();
//            int d = int.Parse(s3);
//            Console.WriteLine("Введите число 5:");
//            string s4 = Console.ReadLine();
//            int e = int.Parse(s4);
//            int mid;
//            mid = (a + b + c + d + e) / 5;
//            Console.WriteLine("Средне Арфиметическое:");
//            Console.Write(mid);
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
//            Random rand = new Random();
//            Console.OutputEncoding = Encoding.GetEncoding(1251);

//            int a = rand.Next(0, 147);
//            Console.WriteLine("Число 1: "+a);

//            int b = rand.Next(0, 147);
//            Console.WriteLine("Число 2: "+b);

//            int c = rand.Next(0, 147);
//            Console.WriteLine("Число 3: "+c);

//            int d = rand.Next(0, 147);
//            Console.WriteLine("Число 4: "+d);

//            int e = rand.Next(0, 147);
//            Console.WriteLine("Число 5: "+e);
//            int mid;
//            mid = (a + b + c + d + e) / 5;
//            Console.WriteLine("Средне Арфиметическое: ");
//            Console.Write(mid);
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

//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            int sk;
//            int sl = sk = 64;//общее количество лапок 
//            int rl = 4;//количество лапок для кролей
//            int dl = 2;//количество лапок для гусей
//            while (sl >= 0)
//            {
//                int r = sl / rl; //количество кролей 
//                int d = (sk - sl) / dl;//количество гусей
//                if ((sl % rl == 0) && ((sk - sl) % dl == 0))
//                {
//                    Console.WriteLine(r + "-кролик."+d + " -гусь");

//                }
//                sl = sl - 1;
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

//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            string password = "root", input = string.Empty;
//            while (input != password)
//            {
//                Console.WriteLine("Введите пароль:");
//                input = Console.ReadLine();
//            }
//            Console.WriteLine("Пароль принят");
//            Console.ReadKey();

//        }
//    }
//}




