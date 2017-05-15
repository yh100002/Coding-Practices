using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomicRangeQuery
{
    class Program
    {
        class GenomicImpact
        {
            public int occurASequence { get; set; }
            public int occurCSequence { get; set; }
            public int occurGSequence { get; set; }

        }

        public static int[] solution(string S, int[] P, int[] Q)
        {
            GenomicImpact[] genomicImpact = new GenomicImpact[S.Length + 1];
            genomicImpact[0] = new GenomicImpact() { occurASequence = 0, occurCSequence = 0, occurGSequence = 0 };

            int a = 0;
            int occurASequence = 0; // 1 impact
            int occurCSequence = 0; // 2 impact
            int occurGSequence = 0; // 3 impact

            foreach(var ch in S)
            {                
                switch (ch)
                {
                    case 'A':
                        occurASequence++;
                        break;
                    case 'C':
                        occurCSequence++;
                        break;
                    case 'G':
                        occurGSequence++;
                        break;
                }
                genomicImpact[a+1] = new GenomicImpact { occurASequence = occurASequence, occurCSequence = occurCSequence, occurGSequence = occurGSequence };
                a++;
            }

            int[] result = new int[P.Length];
            for (int i = 0; i < P.Length; i++)
            {
                int fromIndex = P[i];     // Previous Index
                int toIndex = Q[i]+1;   // one-indexed Original Index

                int DiffOccurASequence = genomicImpact[toIndex].occurASequence - genomicImpact[fromIndex].occurASequence;
                if (DiffOccurASequence > 0)
                {
                    result[i] = 1;
                    continue;
                }
                int DiffOccurCSequence = genomicImpact[toIndex].occurCSequence - genomicImpact[fromIndex].occurCSequence;
                if (DiffOccurCSequence > 0)
                {
                    result[i] = 2;
                    continue;
                }
                int DiffOccurGSequence = genomicImpact[toIndex].occurGSequence - genomicImpact[fromIndex].occurGSequence;
                if (DiffOccurGSequence > 0)
                {
                    result[i] = 3;
                    continue;
                }
                result[i] = 4;
            }

            return result;
        }

        static void Main(string[] args)
        {
            var result = solution("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 });
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}
