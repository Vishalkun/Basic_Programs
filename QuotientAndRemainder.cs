using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_BasicPrograms
{
    internal class QuotientAndRemainder
    {
        public static void qr()
        {
           
               
                int a = 17, b = 5;
                int q, r;
                q = a / b;
                r = a % b; 
                Console.WriteLine("When " + a + " is divided by " + b + ", quotient is " + q + " and remainder is " + r + ".");
                Console.ReadKey();
            
        }
    }
}
    

