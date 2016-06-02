using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double kms = 0, idle = 0, result;
            do
            {
                try
                {
                    Console.Write("kms=");
                    kms = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (kms < 0);
            do
            {
                try
                {
                    Console.Write("idle=");
                    idle = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (idle < 0);
            result = kms > 5 ? 100 + 3 * (kms - 5) + idle : kms * 20 + idle;
            Console.WriteLine("result = " + result);
            //delay
            Console.ReadKey();
        }
    }
}
