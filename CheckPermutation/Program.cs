using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPermutation
{
    class Program
    {
        //접근방법: 순열인 경우를 '수가 중복되지 않을 것' + '합이 N*(N+1)/2일것, 그렇지 않으면  0
        //특이사항: antiSum 테스트케이스가 존재함
        
        static int CheckPermutation(int[] A)
        {
            if (A == null) return 0;

            HashSet<int> set = new HashSet<int>();
            int total = 0;
            foreach(int i in A)
            {
                set.Add(i);
                total += i;
            }
            int permutationSum = (A.Length) * (A.Length + 1) / 2;
            if(total == permutationSum && set.Count == A.Length)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckPermutation(new int[] { 4,1,3,2 }));
            Console.ReadKey();
        }
    }
}
