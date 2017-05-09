using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToInt
{
    class Program
    {
        static int StringToInt(string str)
        {
            int result = 0;

            foreach(char ch in str)
            {
                result *= 10;
                result += ch - '0';
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringToInt("12334"));
        }
    }
}
