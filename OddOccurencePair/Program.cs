using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurencePair
{
    class Program
    {
        static int OddOccurencePair(int[] A)
        {
            HashSet<int> hash = new HashSet<int>();

            foreach(int i in A)
            {
                if(hash.Contains(i) == false)
                {
                    hash.Add(i);
                }
                else
                {
                    hash.Remove(i);
                }
            }
            
            foreach(var a in hash)
            {
                return a;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            int[] odds = new int[] { 9,3,9,3,9,7,9,8 };

            Console.WriteLine(OddOccurencePair(odds));
            Console.ReadKey();
        }
    }
}
