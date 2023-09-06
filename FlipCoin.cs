using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_BasicPrograms
{
    internal class FlipCoin
    {
        public static void Flip()
        {
            Console.WriteLine("Enter the value for the number of flips");
            int flip=int.Parse(Console.ReadLine());

          //  Random random = new Random();   
            //Console.WriteLine(random.Next(0,1));

            int head = 0;
            int tail= 0;
            int headcount = 0;
            int tailcount = 0;

            double headpercentage;
            double tailpercentage;

            
                for(int i = 0;i<flip;i++)
                {
                    Random random = new Random();
                    int coin = random.Next(2);

                  if(coin<0.5)
                  {
                    Console.WriteLine("tails");
                    tail = 1;
                    tailcount += 1;
                    head = 1;
                    headcount += 1;
                  }
                else
                  {
                    Console.WriteLine("head");
                    head = 1;
                    headcount += 1;
                }
                }
            headpercentage = (headcount * 100) / flip;
            tailpercentage= (tailcount * 100)/flip;
            Console.WriteLine("No of headpercentage" + headpercentage);
            Console.WriteLine("No of tailpercentage" + tailpercentage);




        }
    }
}
