using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int mounth;
            do
            {
                try
                {
                    mounth = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                } 
            } while (true);
            switch (mounth)
            {
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Winter");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Spring");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Summer");
                    break;
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Autumn.");
                    break;
                default:
                    Console.WriteLine("No such a year time.");
                    break;
            }
            //delay
            Console.ReadKey();
        }
    }
}
