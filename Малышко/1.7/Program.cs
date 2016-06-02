using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7
{

    class Program
    {
        static bool IsSimple(int num)
        {
            if (num == 2)
            {
                return true;
            }
            if ((num & 1) == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= num; i += 2)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int num = -1;
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
            Console.WriteLine(IsSimple(num) == true ? "simple" : "not simple");
            //delay
            Console.ReadKey();
        }
    }
}
