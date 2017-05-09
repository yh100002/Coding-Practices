using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDivisible
{
    class Program
    {
        /*
         * 접근방법:
time complexity is O(1)을 요구하므로 반복문이 아닌 식으로 해결
A and B are integers within the range [0..2,000,000,000], A값, B값에 0이 올 수 있음
{ i : A ≤ i ≤ B, i mod K = 0 } i값이 0일땐 i mod K는 K값과 관계없이 true
fromNum을 1로 통일하고 계산 & 경계값이 true인 경우 1가산
*/

        static int DivisibleCount1(int A, int B, int K)
        {
            int from = A;
            int To = B;
            int divisibleCount = 0;

            if (from == To && from % K == 0)
                return 1;

            if( from ==0)
            {
                divisibleCount++;
                from = 1;
            }
            
            if(from < K && To >= K)
            {
                from = 1;
            }

            divisibleCount += (To - from) / K;
            if (from % K == 0 || To % K == 0)
            {
                divisibleCount++;
            }

            return divisibleCount;
        }

        static int DivisibleCount2(int A, int B, int K)
        {
            
            //for(var index = A; index <= B; index++) {
            //    if(index % K == 0) count++;
            //}
             
            int result = 0;

            if (A % K == 0)
            {
                result = ((B - A) / K) + 1;
            }
            else
            {
                result = (B / K - ((A / K) + 1)) + 1;
            }

            return result;

            //return B / K - (A / K) + (A % K == 0 ? 1 : 0);
        }


        static void Main(string[] args)
        {
            Console.WriteLine(DivisibleCount1(6, 11, 2));
            Console.WriteLine(DivisibleCount2(6, 11, 2));
            Console.ReadKey();
        }
    }
}
