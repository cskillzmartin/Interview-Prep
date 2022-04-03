using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class CaseInsensitiveStringCompare
    {
        public static bool isSame(string v1, string v2)
        {
            if (v1.Length != v1.Length)
                return false;


            for (int i = 0; i < v1.Length; i++)
            {
                if (char.ToLower(v1[i]) != char.ToLower(v2[i]))
                    return false;
            }

            return true;
        }
    }
}
