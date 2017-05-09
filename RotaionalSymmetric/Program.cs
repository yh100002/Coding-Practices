using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaionalSymmetric
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>()
            {
                { '0','0' },
                { '1','1' },
                { '6','9' },
                { '8','8' },
                { '9','6' }
            };

            Console.WriteLine(isRotationallySymmetric(dic, "0891680"));
            Console.WriteLine(isRotationallySymmetric(dic, null));
            Console.WriteLine(isRotationallySymmetric(dic, "169"));
            Console.WriteLine(isRotationallySymmetric(dic, "5"));

            Console.ReadKey();
        }

        static bool isRotationallySymmetric(Dictionary<char,char> dic,string input)
        {
            if (input == null) return true;

            if (input.Equals(" ")) return true;

            if (input.Equals("2") || input.Equals("3") || input.Equals("4") || input.Equals("5") || input.Equals("7"))
            {
                return false;
            }

            char[] charInput = input.ToCharArray();
            int start = 0;
            int end = input.Length-1;
            while(start < end)
            {
                if(dic.ContainsKey(charInput[end]) == false)
                {
                    return false;
                }

                if (charInput[start] == (char)dic[charInput[end]])
                {
                    start++;
                    end--;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
