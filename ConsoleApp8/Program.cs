using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char deystvie = char.Parse( Console.ReadLine());
            double re = 0.0;
            string chetno = string.Empty;
            switch (deystvie)
            {
                case '+':
                    re = n1 + n2;
                    if (re%2==0)
                    {
                        chetno = "even";
                    }
                    else
                    {
                         chetno = "odd";
                    }
                    Console.WriteLine($"{n1} {deystvie} {n2} = {re} - {chetno}");
                    break;
                case '-':
                    re = n1 - n2;
                    if (re % 2 == 0)
                    {
                         chetno = "even";
                    }
                    else
                    {
                         chetno = "odd";
                    }
                    Console.WriteLine($"{n1} {deystvie} {n2} = {re} - {chetno}");
                    break;
                case '*':
                    re = n1 * n2;
                    if (re % 2 == 0)
                    {
                         chetno = "even";
                    }
                    else
                    {
                         chetno = "odd";
                    }


                    Console.WriteLine($"{n1} {deystvie} {n2} = {re} - {chetno}");


                    break;

                case '/':
                    if (n2!=0)
                    {
                        re = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {re:f2}");
                    }
                    else if (n2==0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    
                 
                    break;
                case '%':
                    if (n2 != 0)
                    {
                        re = n1 % n2;

                        Console.WriteLine($"{ n1} % { n2} = { re}");
                    }
                    else if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }

                    break;




                
            }

           
        }
    }
}
