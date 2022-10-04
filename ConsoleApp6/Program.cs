using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double praznici = double.Parse(Console.ReadLine());
            double uikend = double.Parse(Console.ReadLine());

            double totalUikends = 48-uikend;
            double uikendInSofia = totalUikends * 3 / 4;
            
            double gamesInPraznici = praznici * 2 / 3;
            
            
            double sum = 0.00;
            sum = uikendInSofia + uikend + gamesInPraznici;
            if (year=="leap")
            {
                sum += sum*0.15;
            }
            else if (year=="normal")
            {
                sum = sum + 0;
            }
            sum = Math.Floor(sum);
            Console.WriteLine(sum);
        }
    }
}
