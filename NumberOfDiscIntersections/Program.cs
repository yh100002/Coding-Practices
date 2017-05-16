using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfDiscIntersections
{
    class Program
    {
        class CircleComparer : IComparer<Circle>
        {
            public int Compare(Circle x, Circle y)
            {
                if (x.min > y.min) { return 1; }
                else { return -1; }                
            }
        };

        class Circle
        {
            public int min { get; set; }
            public int max { get; set; }
        };

        public static int solution(int[] A)
        {
            int N = A.Length;
            Circle[] circles = new Circle[N];
            for(int i=0;i<N;i++)
            {
                Circle circle = new Circle();
                circle.min = i - A[i];
                circle.max = i + A[i];
                circles[i] = circle;
            }

            Array.Sort(circles, new CircleComparer());

            int count = 0;

            for(int i=0;i<N-1;i++)
            {
                for(int j=i+1;j<N;j++)
                {
                    if(circles[i].max >= circles[j].min)
                    {
                        count++;
                    }

                    if (count > 10000000) return -1;
                }
            }

            return count;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(solution(new int[] {1,5,2,1,4,0}));
            Console.ReadKey();
        }
    }
}
