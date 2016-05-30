using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _2-_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string n;
//            Console.WriteLine("Enter number:");
//            n = Console.ReadLine();
//            for (int i = 0; i < 21; i++)
//            {
//                Console.WriteLine(n + " * " + i + "=" + Convert.ToInt32(n) * i);
//            }
//        }
//    }
//}


//namespace _2-_2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string n;
//            Console.WriteLine("Enter number:");
//            n = Console.ReadLine();
//            int nn = Convert.ToInt32(n);
//            int i = 0;
//            nn = Convert.ToInt32(n);
//            for (; nn != 0; i++) {nn = nn / 10;}
//            Console.WriteLine(i);
//        }
//    }
//}
//namespace _2-_3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Random rand = new Random();
//            int temp;
//            temp = rand.Next(0,147);
//            string n;
//            for (; ;)
//            {
//                Console.WriteLine("Enter number:");
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
//                    Console.WriteLine("Win!!!");
//                    return;
//                }
//            }
//        }
//    }
//}
//namespace _2-_4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number:");
//            int temp = Convert.ToInt32(Console.ReadLine());
//            int kvadrat = 0;

//            for (int i = 1; ; i++)
//            {
//                kvadrat = i * i;

//                if (kvadrat >= temp)
//                {
//                    return;
//                }
//                Console.WriteLine(kvadrat);
//            }
//        }
//    }
//}
//namespace _2-_5
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
//namespace _2-_6
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
//namespace _2-_7
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            int sk;
//            int sl = sk = 64;// всех звери вместе 
//            int rl = 4;//количество лап для одних зверей (кроли) 
//            int dl = 2;//количество лап для других зверей (гуси) 
//            while (sl >= 0)
//            {
//                int r = sl / rl; // (кроли) 
//                int d = (sk - sl) / dl;// (гуси) 
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
//namespace _2-_8
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.OutputEncoding = Encoding.GetEncoding(1251);
//            string password = "root", input = string.Empty;
//            while (input != password)
//            {
//                Console.WriteLine("Enter Password:");
//                input = Console.ReadLine();
//            }
//            Console.WriteLine("Password accepted");
//            Console.ReadKey();
//        }
//    }
//}




