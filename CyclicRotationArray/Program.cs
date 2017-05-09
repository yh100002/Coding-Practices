using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclicRotationArray
{
    class Program
    {
        static int[] CyclicRotationArray(int[] A, int K)
        {
            //  Rotate an array to the right by a given number of steps.
            //  eg k= 0 A = [3, 8, 9, 7, 6] the result is newArray = [3, 8, 9, 7, 6]
            //  eg k= 1 A = [3, 8, 9, 7, 6] the result is newArray = [6, 3, 8, 9, 7]
            //  eg k= 3 A = [3, 8, 9, 7, 6] the result is newArray = [9, 7, 6, 3, 8]

            //  int iOffset;
            int iArraySize = A.Length;
            int[] newArray = new int[iArraySize];

            for (int i = 0; i < iArraySize; i++)
            {
                //      iOffset=(k+i) % iArraySize;
                //      newArray[i] = A[iOffset];
                //newArray[i] = A[(K + i) % iArraySize];
                newArray[(K + i) % iArraySize] = A[i];
            }
            return newArray;
        }
     
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3,8,9,7,6 };

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(var e in CyclicRotationArray(arr, 0))
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("");
            foreach (var e in CyclicRotationArray(arr, 1))
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("");
            foreach (var e in CyclicRotationArray(arr, 2))
            {
                Console.Write("{0} ", e);
            }
            Console.WriteLine("");
            foreach (var e in CyclicRotationArray(arr, 3))
            {
                Console.Write("{0} ", e);
            }

            Console.ReadKey();

        }
    }
}
