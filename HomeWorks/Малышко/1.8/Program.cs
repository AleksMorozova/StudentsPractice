using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1, randResult;
            Random rand = new Random();
            do
            {
                try
                {
                    Console.Write("num=");
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (num < 0);

            randResult = rand.Next(1, 13);
            if (randResult < 6)
            {
                Console.WriteLine("Loser! Ha ha! You won nothing, nigga.");
            }
            else if (randResult < 9)
            {
                Console.WriteLine(num);
            }
            else if (randResult < 12)
            {
                Console.WriteLine(num * 2);
            }
            else
            {
                Console.WriteLine(num * 10);
            }
            //delay
            Console.ReadKey();
        }
    }
}
