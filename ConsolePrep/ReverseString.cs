using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class ReverseString
    {
        public static string _ReverseString(string val)
        {
            var rtnValue = new char[val.Length];
            for (int i = 0, j = val.Length - 1; i < val.Length && j >= i; i++, j--)
            {
                var temp = val[i];
                rtnValue[i] = val[j];
                rtnValue[j] = temp;
            }

            return new string(rtnValue);
        }

        public static string Reverse(string v1)
        {
            var rtnValue = new char[v1.Length];
            for (int i = 0, j = v1.Length - 1; v1.Length % 2 == 0 ? i < j : i <= j; j--, i++)
            {
                rtnValue[j] = v1[i];
                rtnValue[i] = v1[j];
            }
            return new string(rtnValue);
        }


        public void ReverseTheBrain()
        {
            char[] myChars = { 'p', 'e', 'r', 'f', 'e', 'c', 't', ' ', 'm', 'a', 'k', 'e', 's', ' ', 'p', 'r', 'a', 'c', 't', 'i', 'c', 'e' };
            for (int i = 0; i < myChars.Length; i++)
            {
                Console.Write(myChars[i]);
            }
            Console.WriteLine();
            ReverseStringz(ref myChars);
            for (int i = 0; i < myChars.Length; i++)
            {
                Console.Write(myChars[i]);
            }
            Console.WriteLine();
            ReverseWord(ref myChars);

            for (int i = 0; i < myChars.Length; i++)
            {
                Console.Write(myChars[i]);
            }
        }


        public static void ReverseStringz(ref char[] val)
        {
            for (int i = 0, j = val.Length - 1; i < j; i++, j--)
            {
                var temp = val[i];
                val[i] = val[j];
                val[j] = temp;
            }
        }

        public static void ReverseWord(ref char[] val)
        {
            var stops = new List<int>() { 0 };

            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] == ' ')
                    stops.Add(i);
            }

            for (int i = 1; i < stops.Count; i++)
            {
                int k = stops[i] - 1;
                for (int start = stops[i - 1]; start <= k; start++, k--)
                {
                    var temp = val[start];
                    val[start] = val[k];
                    val[k] = temp;
                }
            }
        }
    }
}
