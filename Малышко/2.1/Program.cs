using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            do
            {
                try
                {
                    Console.Write("value=");
                    num = System.Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (num < 0);
            for (int i = 1; i < 21; ++i)
            {
                Console.WriteLine(num * i);
            }
            //delay
            Console.ReadKey();
        }
    }
}
