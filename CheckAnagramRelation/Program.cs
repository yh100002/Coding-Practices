using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAnagramRelation
{
    class Program
    {
        static bool CheckAnagramWithArray(string str1,string str2)
        {
            if (str1.Length != str2.Length) return false;

            int[] letters = new int[256];
            foreach(char ch in str1)
            {
                letters[ch]++;
            }

            foreach(char ch in str2)
            {
                letters[ch]--;
                if (letters[ch] < 0) return false;
            }

            return true;
        }

        static bool CheckAnagramWithArray2(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach(char ch in str1)
            {
                if(dic.ContainsKey(ch) == true)
                {
                    dic[ch]++;
                }
                else
                {
                    dic.Add(ch, 1);
                }
            }

            foreach(char ch in str2)
            {
                if (dic.ContainsKey(ch) == false) return false;

                if (dic[ch] == 0) return false;

                dic[ch]--;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckAnagramWithArray("ASD", "DAS"));
            Console.WriteLine(CheckAnagramWithArray2("ASD", "DAS"));

            Console.ReadKey();
        }
    }
}
