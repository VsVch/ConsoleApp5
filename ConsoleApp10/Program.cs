using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double haourExam = double.Parse(Console.ReadLine());
            double minutExam = double.Parse(Console.ReadLine());
            double haourAriv = double.Parse(Console.ReadLine());
            double minutAriv = double.Parse(Console.ReadLine());
            double minCheck = 0.0;
            if (minutAriv-30<0)
            {
                haourAriv -= 1;
                minCheck = 30 + minutAriv;
                Console.WriteLine(haourAriv);
                Console.WriteLine(minCheck);
            }




        }
    }
}
