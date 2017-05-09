using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckUniqueCh
{
    class Program
    {
        static bool CheckUniqueCh1(string str)
        {
            bool[] flags = new bool[256];
            foreach(char ch in str)
            {
                if(flags[ch] == true)
                {
                    return false;
                }

                flags[ch] = true;
            }

            return true;
        }

        static bool CheckUniqueCh2(string str)
        {
            var hashSet = new HashSet<char>();
            foreach(char ch in str)
            {
                if(hashSet.Add(ch) == false)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckUniqueCh1("asdea"));
            Console.WriteLine(CheckUniqueCh2("asde"));

            Console.ReadKey();

        }
    }
}
