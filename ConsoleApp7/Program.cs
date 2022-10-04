using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string seson = Console.ReadLine();
            double cash = 0.0;
            string destination = string.Empty;
            if (budjet<=100)
            {
                destination ="Bulgaria";

                if (seson=="summer")
                {
                    cash = budjet * 30 / 100;
                }
                else if (seson=="winter")
                {
                    cash = budjet * 70 / 100;
                }


            }
            else if (100<budjet&&budjet<=1000)
            {
                destination = "Balkans";
                if (seson == "summer")
                {
                    cash = budjet * 40 / 100;
                }
                else if (seson == "winter")
                {
                    cash = budjet * 80 / 100;
                }



            }
            else if (budjet>1000)
            {
                destination ="Europe";
                cash = budjet * 90 / 100;
            }

            Console.WriteLine($"Somewhere in {destination}");

            if (seson =="winter"||destination=="Europe")
            {
                Console.WriteLine($"Hotel - {cash:f2}");
            }
            else if (seson == "summer")
            {
                Console.WriteLine($"Camp - {cash:f2}");
            }

            

        }
    }
}
