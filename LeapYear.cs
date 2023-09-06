using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_BasicPrograms
{
    internal class LeapYear
    {
        public static void Leap()
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("it is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("it is not a Leap Year.", Year);
                Console.ReadLine();
            }
        }
    }
}
