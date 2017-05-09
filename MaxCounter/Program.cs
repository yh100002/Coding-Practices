using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCounter
{
    class Program
    {
        static int[] MaxCounters(int N, int[] A)
        {
            int[] counters = new int[N];
            int maxcounter = 0;
            int maxvalue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                int X = A[i];
                if (X >= 1 && X <= N)
                { // this encodes increment(X), with X=A[i] 
                    if (counters[X-1] < maxcounter)
                    {
                        counters[X-1] = maxcounter;
                    }

                    counters[X - 1]++; //-1, because our index is 0-based

                    if(maxvalue < counters[X-1])
                    {
                        maxvalue = counters[X - 1];
                    }

                }
                if (X == N + 1)
                {// this encodes setting all counters to the max value
                    maxcounter = maxvalue;                 
                }
            }

            for (int i = 0; i < N; i++)
            {
                if (counters[i] < maxcounter)
                {
                    counters[i] = maxcounter;
                }
            }

            return counters;
        }
        static void Main(string[] args)
        {
            var result = MaxCounters(5, new int[] { 3, 4, 4, 6, 1, 4, 4 });
            Console.ReadKey();
        }
    }
}
