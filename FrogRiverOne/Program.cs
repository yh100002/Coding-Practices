using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
    class Program
    {
        //접근방법: 1~X(중복은 무시)까지 수가 모두 순열이 되는 시점은 집합 구성요소가 X인 시점이다.        
        static int CalcFrogRiverOne(int X,int[] A)
        {
            if (A == null) return 0;
            HashSet<int> set = new HashSet<int>();
            for(int i=0;i<A.Length;i++)
            {
                if(A[i] <= X)
                {
                    set.Add(A[i]);
                    if(set.Count == X)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CalcFrogRiverOne(5, new int[] {1,3,1,4,2,3,5,4}));
            Console.ReadKey();
        }
    }
}
