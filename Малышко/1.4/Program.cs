using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToBoolean(Convert.ToInt32(Console.ReadLine())) == true ? "Good" : "Bad");
            //delay
            Console.ReadKey();
        }
    }
}
