using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 5.00;
            if (type=="Premiere")
            {
                income = rows * colums * 12;
            }
            else if (type=="Normal")
            {
                income = rows * colums * 7.5;
            }
            else if (type=="Discount")
            {
                income = rows * colums * 5;
            }


            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
