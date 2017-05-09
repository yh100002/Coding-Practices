using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJump
{
    class Program
    {
        static int CountMinimalFrogJumpLoop(int X, int Y, int D)
        {
            int counter = 0;
            do
            {
                X += D;
                counter++;
            }
            while (X <= Y);
            return counter;
        }

        static int CountMinimalFrogJumpCalc(int X, int Y, int D)
        {
            int distance = Y - X;

            if((distance % D) == 0)
            {
                return distance / D;
            }
            else
            {
                return (distance + D) / D;
            }            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountMinimalFrogJumpLoop(10, 15, 30));
            Console.WriteLine(CountMinimalFrogJumpCalc(10, 15, 30));

            Console.ReadKey();
        }
    }
}
