using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxProductOfThree
{
    class Program
    {
        public static int solution(int[] A)
        {
            Array.Sort(A);
            int a = 0;
            if (A[0] < 0 && A[1] < 0)
                a = A[0] * A[1] * A[A.Length - 1];
            int b = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];

            if (a > b /*&& (A[0] < 0 && A[1] < 0)*/) return a;
            else return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] {-3,1,2,-2,5,6}));
            Console.ReadKey();
        }
    }
}
