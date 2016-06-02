using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
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
            for (int i = 1; i * i < num; ++i)
            {
                Console.WriteLine(i * i);
            }
            //delay
            Console.ReadKey();
        }
    }
}
