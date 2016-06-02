using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                input = Console.ReadLine();
            } while (input != "a" && input != "b");
            Console.Clear();
            if (input == "a")
            {
                Console.WriteLine("Make cat eat.");
            }
            else
            {
                Console.WriteLine("Go out with the dog.");
            }

            //delay
            Console.ReadKey();
        }
    }
}
