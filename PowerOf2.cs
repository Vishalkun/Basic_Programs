﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_BasicPrograms
{
    internal class PowerOf2
    {
        public static void power2()
        {
            int n, pow, i;
            for(i = 0; i < 10; i++)
            {
                pow = 1;
                n = i;

                while(n > 0)
                {
                    pow *= 2;
                    n--;
                }
            Console.WriteLine(pow);

            }
        }
    }
}
