using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class LongestCommonSubsquenceConsole
    {
        public static string getSubCommonSequence(string v1, string v2)
        {
            var rtnValue = string.Empty;

            var StartSubSearch = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                var currentChar = v1[i];
                for (int j = StartSubSearch; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        rtnValue += v1[i];
                        StartSubSearch = j;
                        break;
                    }
                }
            }


            return rtnValue;
        }
    }
}
