using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunLengthEncode
{
    class Program
    {

        static string RunLengthEncoding(string str)
        {
            if (str == null) return null;

            var ca = str.ToCharArray();
            string result = "";
            int count = 0;
            char prev = ca[0];

            foreach(char ch in ca)
            {
                if (prev == ch) count++;
                else
                {
                    result += prev + count.ToString();
                    prev = ch;
                    count = 1;                        
                }
            }
            result += prev + count.ToString();

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RunLengthEncoding("aaaassdd"));
            Console.ReadKey();
        }
    }
}
