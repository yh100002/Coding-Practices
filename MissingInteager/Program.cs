using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissingInteager
{
    class Program
    {
        static int GetMissingInteger(int[] A)
        {
            if (A == null) return 0;

            bool[] tempA = new bool[A.Length + 1];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] <= A.Length)
                {
                    tempA[A[i]] = true;
                }
            }

            for (int i = 1; i < tempA.Length; i++)
            {
                if (false == tempA[i])
                {
                    return i;
                }
            }
            return tempA.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMissingInteger(new int[] {1,3,6,4,1,2}));
            Console.ReadKey();
        }
    }
}
