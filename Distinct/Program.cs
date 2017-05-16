using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct
{
    class Program
    {
        public static int Distinct(int[] A)
        {
            //return A.Distinct().Count();
            if (A.Length == 0) return 0;
            if (A.Length == 1) return 1;

            Array.Sort(A);
            int count = 1;
            int prev = A[0];
            foreach(var item in A)
            {
                if(prev != item)
                {
                    count++;
                }
                prev = item;
            }

            return count;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(Distinct(new int[] {6,2,1,1,2,3,1 }));
            Console.ReadKey();
        }
    }
}
