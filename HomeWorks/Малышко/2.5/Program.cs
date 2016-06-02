using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, num;
                
            for (int i = 0; i < 5; ++i)
            {
                do
                {
                    try
                    {
                        Console.Write("value=");
                        num = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (true);
                sum += num;
            }
            Console.WriteLine((sum/5).ToString("0.000"));
            //delay
            Console.ReadKey();
        }
    }
}
