using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingElement
{
    class Program
    {

        static int FindMissingElement(int[] A)
        {
            Array.Sort(A);
            int ret = A.Length + 1;

            for(int i=0;i<A.Length;i++)
            {
                if(A[i] != i+1)
                {
                    return i + 1;
                }
            }

            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindMissingElement(new int[] {1,2,3,5,6,7}));
            Console.ReadKey();
        }
    }
}
