using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 65; i+=4)
            {
                Console.WriteLine(i/4 + " " + (64- i)/2);
            }
            //dealy
            Console.ReadKey();
        }
    }
}
