using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    public class EditDistanceOfGreaterThan1
    {
        public static bool GreaterThanOneDistance(string v1, string v2)
        {
            int rtnValue = 0;

            if (v1.Length >= v2.Length)
            {
                rtnValue = v1.Length - v2.Length;
                if (rtnValue > 1)
                    return false;

                rtnValue += CharByChar(ref v1, ref v2);
            }
            else if (v1.Length < v2.Length)
            {
                rtnValue = v2.Length - v1.Length;
                if (rtnValue > 1)
                    return false;

                rtnValue += CharByChar(ref v2, ref v1);
            }

            return rtnValue > 1;
        }

        public static int CharByChar(ref string v1, ref string v2)
        {
            int rtnValue = 0;
            for (int i = 0; i < v2.Length; i++)
            {
                if (char.ToLower(v1[i]) != char.ToLower(v2[i]))
                    rtnValue++;
            }
            return rtnValue;
        }
    }
}
