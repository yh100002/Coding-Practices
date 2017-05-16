using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        public static int IsTriplet(int[] A)
        {
            if (A == null || A.Length < 3) return 0;

            Array.Sort(A);
            for(long i=0;i<A.Length-2;i++)
            {
                long temp = (long)A[i] + (long)A[i + 1];
                if (temp > (long)A[i+2])
                {
                    return 1;
                }
            }

            return 0;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(IsTriplet(new int[] { 10,2,5,1,8,20}));
            Console.ReadKey();
        }
    }
}
