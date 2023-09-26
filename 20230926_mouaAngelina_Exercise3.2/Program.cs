using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurricanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the wind speed?: ");
            string windSpeed = Console.ReadLine();
            char[] charsToTrim = { 'm', 'p', 'h' };
            decimal Speed = Convert.ToDecimal(windSpeed.Trim(charsToTrim));
            if (Speed >= 157)
            {
                Console.WriteLine("Category Five Hurricane");
                Console.ReadLine();
            }
            else if (Speed >= 130)
            {
                Console.WriteLine("Category Four Hurricane");
                Console.ReadLine();
            }
            else if (Speed >= 111)
            {
                Console.WriteLine("Category Three Hurricane");
                Console.ReadLine();
            }
            else if (Speed >= 96)
            {
                Console.WriteLine("Category Two Hurricane");
                Console.ReadLine();
            }
            else if (Speed >= 74)
            {
                Console.WriteLine("Category One Hurricane");
                Console.ReadLine();
            }
            else if (Speed < 74)
            {
                Console.WriteLine("Not A Hurricane");
                Console.ReadLine();
            }



        }
    }
}
