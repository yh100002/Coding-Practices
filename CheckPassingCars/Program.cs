using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPassingCars
{
    class Program
    {
        static int CheckPassingCars(int[] A)
        {
            if (null == A)
            {
                return -1;
            }
            int cur_zero_count = 0;
            int total_pair_of_cars = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (0 == A[i])
                {
                    cur_zero_count++;
                }
                else if (1 == A[i])
                {
                    total_pair_of_cars += cur_zero_count;
                    if (total_pair_of_cars > 1000000000)
                    {
                        return -1;
                    }
                }
            }
            return total_pair_of_cars;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPassingCars(new int[] {0,1,0,1,1}));
            Console.ReadKey();
        }
    }
}
