using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantity = -1;
            double uah = 1;
            double usd = 25;
            double eur = 28;
            string currency;
            do
            {
                try
                {
                    Console.Write("value=");
                    quantity = System.Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
            } while (quantity < 0);
            do
            {
                currency = Console.ReadLine();
            } while (currency != "uah" && currency != "eur" && currency != "usd");
            switch (currency)
            {
                case "uah":
                    Console.WriteLine(quantity + " uah in usd = " + (quantity * (uah / usd)).ToString("0.000") + "\nin eur = " + (quantity * (uah / eur)).ToString("0.000"));
                    break;
                case "usd":
                    Console.WriteLine(quantity + " usd in uah = " + (quantity * (usd / uah)).ToString("0.000") + "\nin eur = " + (quantity * (usd / eur)).ToString("0.000"));
                    break;
                case "eur":
                    Console.WriteLine(quantity + " eur in uah = " + (quantity * (eur / uah)).ToString("0.000") + "\nin usd = " + (quantity * (eur / usd)).ToString("0.000"));
                    break;
                default:
                    break;
            }

            //delay
            Console.ReadKey();
        }
    }
}
