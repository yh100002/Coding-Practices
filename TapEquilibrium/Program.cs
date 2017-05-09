using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapEquilibrium
{
    class Program
    {
        //접근방법: two parts로 나누면 '좌측편의 합'과 '우측편의 합'은 '전체합'이다. 우측편의 합 = 전체합 - 좌측편의 합
        static int CalcMinTapeEquilibrium(int[] A)
        {
            if (A == null) return 0;
            if (A.Length == 1) return 0;

            int totalSum = A.Sum();
            int leftSum = 0;
            int rightSum = 0;
            int minDiff = int.MaxValue;
            int currDiff = 0;
            for(int i=0;i<A.Length-1;i++)
            {
                leftSum += A[i];
                rightSum = totalSum - leftSum;
                currDiff = Math.Abs(rightSum - leftSum);
                if (currDiff == 0) return 0;
                if (currDiff < minDiff) minDiff = currDiff;
            }

            return minDiff;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalcMinTapeEquilibrium(new int[] {3,1,2,4,3}));
            Console.ReadKey();
        }
    }
}
