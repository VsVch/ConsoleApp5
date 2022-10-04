using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());
            double discountStudio = 0.0;
            double discountAppartment = 0.0;
            double priceStudio = 0.0;
            double priceAppartment = 0.0;
            double cashForApar = 0.0;
            double cashForStudio = 0.0;


            if (count>14)
            {
                
                discountAppartment = 0.1;
                switch (mounth)
                {
                    case "May":
                    case "October":
                        priceStudio = 50;
                        priceAppartment = 65;
                        if (count > 14)
                        {
                            
                            discountStudio = 0.3;
                            cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                            cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                            Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                            Console.WriteLine($"Studio: {cashForStudio:f2} lv.");

                        }
                        else if (count > 7)
                        {
                            
                            discountStudio = 0.05;
                            cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                            cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                            Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                            Console.WriteLine($"Studio: {cashForStudio:f2} lv.");
                        }
                        break;

                    case "June":
                    case "September":
                        priceStudio = 75.2;
                        priceAppartment = 68.7;
                        cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                        cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                        Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                        Console.WriteLine($"Studio: {cashForStudio:f2} lv.");

                        break;

                    case "July":
                    case "August":
                        priceStudio = 76;
                        priceAppartment = 77;
                        cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                        cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                        Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                        Console.WriteLine($"Studio: {cashForStudio:f2} lv.");

                        break;



                }


            }
            else
            {
                switch (mounth)
                {
                    case "May":
                    case "October":
                        priceStudio = 50;
                        priceAppartment = 65;
                        if (count > 14)
                        {
                            
                            discountStudio = 0.3;
                            cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                            cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                            Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                            Console.WriteLine($"Studio: {cashForStudio:f2} lv.");

                        }
                        else if (count > 7)
                        {
                            
                            discountStudio = 0.05;
                            cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                            cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                            Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                            Console.WriteLine($"Studio: {cashForStudio:f2} lv.");
                        }
                        break;

                    case "June":
                    case "September":
                        priceStudio = 75.2;
                        priceAppartment = 68.7;
                        cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                        cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                        Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                        Console.WriteLine($"Studio: {cashForStudio:f2} lv.");

                        break;

                    case "July":
                    case "August":
                        priceStudio = 76;
                        priceAppartment = 77;
                        cashForApar = priceAppartment * count - priceAppartment * discountAppartment * count;
                        cashForStudio = priceStudio * count - priceStudio * discountStudio * count;
                        Console.WriteLine($"Apartment: {cashForApar:f2} lv.");
                        Console.WriteLine($"Studio: {cashForStudio:f2} lv.");

                        break;



                }
            }
            



        }
    }
}
