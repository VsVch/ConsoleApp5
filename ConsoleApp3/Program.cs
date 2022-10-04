using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            double price = 0.0;
            



            switch (flowers)
            {
                case "Roses":
                    price = 5;
                    if (count>80)
                    {
                        price -= price * .1;
                        
                    }
                    break;
                case "Dahlias":
                    price = 3.8;
                    if (count > 90)
                    {
                        price -= price * .15;

                    }
                    break;
                case "Tulips":
                    price = 2.8;
                    if (count > 80)
                    {
                        price -= price * .15;

                    }
                    break;
                case "Narcissus":
                    price = 3;
                    if (count < 120)
                    {
                        price += price * .15;

                    }
                    break;
                case "Gladiolus":
                    price = 2.5;
                    if (count < 80)
                    {
                        price += price * .2;

                    }
                    break;



            }
            double razlika = Math.Abs(budjet - count * price);
            if (budjet>=count*price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {razlika:f2} leva left.");


            }
            else if (budjet<count*price)
            {
                Console.WriteLine($"Not enough money, you need {razlika:f2} leva more.");
            }


        }
    }
}
