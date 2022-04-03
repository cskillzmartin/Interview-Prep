using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    public class FindMissing
    {
        public static int find_missing(int[] ar, int[] ar2)
        {
            var rtn = new HashSet<int>();
            for (int i = 0, j = ar2.Length - 1; i < ar2.Length && j >= i; i++, j--)
            {
                if (!rtn.Contains(ar2[i]))
                    rtn.Add(ar[i]);

                if (!rtn.Contains(ar2[j]))
                    rtn.Add(ar2[j]);
            }

            for (int i = 0, j = ar.Length - 1; i < ar.Length && j >= i; i++, j--)
            {
                if (!rtn.Contains(ar[i]))
                    return ar[i];

                if (!rtn.Contains(ar[j]))
                    return ar[j];
            }

            return -1;
        }

        public static int _FindMissing(int[] v1, int[] v2)
        {
            var d = new HashSet<int>();
            for (int i = 0; i < v2.Length; i++)
            {
                if (!d.Contains(v2[i]))
                    d.Add(v2[i]);
            }

            for (int i = 0, j = v1.Length - 1; v1.Length % 2 == 0 ? i < j : i <= j; i++, j--)
            {
                if (!d.Contains(v1[i]))
                    return v1[i];

                if (!d.Contains(v1[j]))
                    return v1[j];
            }

            return -1;
        }
    }
}
