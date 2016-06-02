using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int randValue = new Random().Next(1, 147);
            do
            {
                try
                {
                    Console.Write("num=");
                    num = System.Convert.ToInt32(Console.ReadLine());
                    if (num < randValue)
                    {
                        Console.WriteLine("more");
                    }
                    else if(num > randValue)
                    {
                        Console.WriteLine("less");
                    }
                    else
                    {
                        Console.WriteLine("ok");
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);

            //delay
            Console.ReadKey();

        }
    }
}
