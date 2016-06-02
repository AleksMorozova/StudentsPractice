using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Random rand = new Random();
            for (int i = 0; i < 5; ++i)
            {
                sum += rand.Next();
            }
            Console.WriteLine(sum/5);
            //delay
            Console.ReadKey();
        }
    }
}
