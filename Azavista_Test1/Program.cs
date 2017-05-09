using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azavista_Test1
{
    class Tree
    {
        public int x;
        public Tree l;
        public Tree r;
    }

    class Program
    {
        public static int OctalToDecimal(string octal)
        {
            int octLength = octal.Length;
            double dec = 0;

            for (int i = 0; i < octLength; ++i)
            {
                dec += ((byte)octal[i] - 48) * Math.Pow(8, ((octLength - i) - 1));
            }

            return (int)dec;
        }

        public static int solution(int[] A)
        {
            int result = 0;
            for(int i=0;i<A.Length;i++)
            {
                result += A[i]*(int)Math.Pow(8, i);
            }
            int count = Convert.ToString(result, 2).ToCharArray().Count(c => c == '1');

            return count;
        }

        static void Main(string[] args)
        {
            solution(new int[] { 1,5,6});
        }
    }
}
