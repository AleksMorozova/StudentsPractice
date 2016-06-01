using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Project 0 
//{
//   class Ivanova
//    {
//        static void Main(string[] args)
//        {            
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 1");
//            Console.WriteLine("+-------------------------------+");
//            Console.WriteLine("Иванова Елена Анатольевна");
//            Console.WriteLine("+-------------------------------+");
//            Console.ReadKey();
//        }
//    }
//}

//namespace Project 1.1
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 1.Блок 1");
//            Console.WriteLine("Введите первое число:");
//            var firstNum = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Введите второе число:");
//            var secondNum = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Из двух чисел наибольшее число : ");
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
//namespace Project 1.2
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 2.Блок 1");
//            Console.WriteLine("Введите фразу:");
//            var phrase = Console.ReadLine();
//            if (phrase != "мяу" && phrase != "гав")
//            {
//                Console.WriteLine("Введенная вами фраза неправильная.");
//            }
//            else
//            {
//                Console.WriteLine(phrase == "мяу" ? "Покорми кота : "Погуляй с собакой!");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace Project 1.3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 3.Блок 1");
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
//            else if (mounthNum == 1 || mounthNum == 12 || mounthNum == 2)
//            {
//                Console.WriteLine("Зима");
//            }
//            else if (mounthNum > 2 && mounthNum < 6)
//            {
//                Console.WriteLine("Весна");
//            }
//            else if (mounthNum >= 6 && mounthNum < 9)
//            {
//                Console.WriteLine("Лето");
//            }
//            else if (mounthNum >= 9 && mounthNum < 12)
//            {
//                Console.WriteLine("Осень");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace Project 1.4
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 4.Блок 1");
//            Console.WriteLine("Введите число:");
//            var number = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine(number == 1 ? "Хорошо!" : number == 0 ? "Плохо!" : "NULL");
//            Console.ReadKey();
//        }
//    }
//}

//namespace Project 1.5
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            var daysOfAWeek = new List<string>();
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 5.Блок 1");
//            daysOfAWeek.Add("Воскресенье");
//            daysOfAWeek.Add("Понедельник");
//            daysOfAWeek.Add("Вторник");
//            daysOfAWeek.Add("Среда");
//            daysOfAWeek.Add("Четверг");
//            daysOfAWeek.Add("Пятница");
//            daysOfAWeek.Add("Суббота");
//            while (true)
//            {
//                Console.WriteLine("Введите день недели по его номеру: ");
//                var number = Convert.ToInt32(Console.ReadLine());
//                try
//                {
//                    Console.WriteLine(daysOfAWeek[number]);
//                }
//                catch (Exception)
//                {
//                    Console.WriteLine("Такого дня в недели не существует.");
//                }

//            }
//        }
//    }

//}

//namespace Project 1.6
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 6.Блок 1");
//            Console.WriteLine("Введите количество километров: ");
//            var tripLength = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Введите количество минут простоя: ");
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
//            Console.WriteLine("Поездка будет стоить: {cost}");
//            Console.ReadKey();
//        }
//    }
//}

//namespace Project 1.7
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 7.Блок 1");
//            Console.WriteLine("Введите натуральное число:");
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
//                Console.WriteLine("Число простое");
//            }
//            else
//            {
//                Console.WriteLine("Число не является простым!");
//            }
//            Console.ReadKey();
//        }
//    }
//}

//namespace Project 1.8
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 8.Блок 1");
//            var random = new Random();
//            var res = random.Next(1, 12);
//            Console.WriteLine("Ваша ставка:");
//            int wager = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Выпавшее число :{res}");
//            if (res >= 1 && res <= 5)
//            {
//                Console.WriteLine("Вы проиграли!");
//            }
//            if (res >= 6 && res <= 8)
//            {
//                wager -= wager;
//                Console.WriteLine("Вы выиграли:  {wager}!");
//            }
//            if (res >= 9 && res <= 11)
//            {
//                wager += wager;
//                Console.WriteLine("Вы выиграли:  {wager}!");
//            }
//            if (res == 12)
//            {
//                wager = 10 * wager;
//                Console.WriteLine("Вы выиграли: {wager}!");
//            }
//            Console.ReadKey();
//        }
//    }
//}
//namespace Project 1.9
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//                Console.OutputEncoding = Encoding.GetEncoding(1251);
//                Console.WriteLine("Задание 9.Блок 1");
//                Console.WriteLine("Введите сумму:");
//                double number = Convert.ToDouble(Console.ReadLine());
//                int temp1 = 0;
//                Console.WriteLine("1-grn\n2-dollar\n3-euro");
//                Console.WriteLine("Введите валютный номер:");
//                int temp = Convert.ToInt32(Console.ReadLine());
//                if (temp == 1)
//                {
//                    Console.WriteLine("Введите номер перевода валюты:");
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
//                    Console.WriteLine("Введите номер перевода валюты:");
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
//                    Console.WriteLine("Введите номер перевода валюты:");
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

//namespace Project 2.1
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 1.Блок 2");
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


//namespace Project 2.2
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 2.Блок 2");
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
//namespace Project 2.3
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 3.Блок 2");
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
//                    Console.WriteLine("Вы выиграли!!!");
//                    return;
//                }
//            }
//        }
//    }
//}
//namespace Project 2.4
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 4.Блок 2");
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
//namespace Project 2.5
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 5.Блок 2");
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
//namespace Project 2.6
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 6.Блок 2");
//            Random rand = new Random();
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
//namespace Project 2.7
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 7.Блок 2");
//            int sk;
//            int sl = sk = 64;// количество лапок всех зверушек вместе 
//            int rl = 4;//количество лапок для одних зверушек (кроли) 
//            int dl = 2;//количество лапок для других зверушек (гуси) 
//            while (sl >= 0)
//            {
//                int r = sl / rl; //количество одних зверушек (кроли) 
//                int d = (sk - sl) / dl;//количество других зверушек (гуси) 
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

//namespace Project 2.8
//{
//    class Ivanova
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            Console.WriteLine("Задание 8.Блок 2");
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
