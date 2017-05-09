using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        public static int ComputeLargestBinaryGap(int value)
        {
            return Convert
            // convert to binary
            .ToString(value, 2)
            // remove leading and trailing 0s, as per requirement
            .Trim('0')
            // split the string by 1s
            .Split(new[] { '1' })
            // find the length of longest segment
            .Max(x => x.Length);            
        }

        private static int ComputeLargestBinaryGap2(int x)
        {
            int[] t = new[]{ x };
            BitArray ba = new BitArray(new[] { x });
            
            int maxCount = 0;
            int startGapIndex = -1;

            //1001
            for (int i = 0; i < ba.Length; i++)
            {
                if (!ba[i])
                    continue;

                if (startGapIndex != -1)
                {
                    int count = i - startGapIndex - 1;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                startGapIndex = i;
            }
            return maxCount;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ComputeLargestBinaryGap2(1041));
            Console.ReadKey();
        }
    }
}
