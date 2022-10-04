using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double price = 0.0;
            

            if (sezon=="Spring")
            {
                price = 3000;
                if (count<=6)
                {
                    price -= price * .1;
                }
                else if (6< count && count<=11)
                {
                    price -= price * 0.15;

                }
                else if (count>12)
                {
                    price -= price*0.25;
                }
            }
            else if (sezon=="Summer")
            {
                price = 4200;
                if (count <= 6)
                {
                    price -= price * 0.1;
                }
                else if (6 < count && count <= 11)
                {
                    price -= price * 0.15;

                }
                else if (count > 12)
                {
                    price -= price * 0.25;
                }
            }
            else if (sezon=="Autumn")
            {
                price = 4200;
                if (count <= 6)
                {
                    price -= price * 0.1;
                }
                else if (6 < count && count <= 11)
                {
                    price -= price * 0.15;

                }
                else if (count > 12)
                {
                    price -= price * 0.25;
                }

            }
            else if (sezon == "Winter")
            {
                price = 2600;
                if (count <= 6)
                {
                    price -= price * 0.1;
                }
                else if (6 < count && count <= 11)
                {
                    price -= price * 0.15;

                }
                else if (count > 12)
                {
                    price -= price * 0.25;
                }
            }
            if (count%2==0)
            {
                switch (sezon)
                {
                    
                    case "Autumn":
                        price = price + 0;
                        break;
                    case "Winter":
                    case "Summer":
                    case "Spring":
                        price -= price * 0.05;

                        break;

                }
            }
            
            if (budjet>=price)
            {
                Console.WriteLine($"Yes! You have {budjet-price:f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price-budjet:f2} leva.");
            }

           
        }
    }
}
