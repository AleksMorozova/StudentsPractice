using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, rank = 0;
            do
            {
                try
                {
                    Console.Write("value=");
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
            do
            {
                num /= 10;
                ++rank;
            } while (num > 0);
            Console.WriteLine(rank);
            //delay
            Console.ReadKey();
        }
    }
}
