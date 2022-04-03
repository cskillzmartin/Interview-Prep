using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    public class GetNthSmallestNumber
    {
        public static int GetNSmallest(int[] ar, int n)
        {
            if (ar.Length < 3)
                return -1;

            var hmap = new HashSet<int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (!hmap.Contains(ar[i]))
                {
                    hmap.Add(ar[i]);
                }
            }

            ar = new int[hmap.Count];
            for (int i = 0; i < hmap.Count; i++)
            {
                ar[i] = hmap.ElementAt(i);
            }

            ar = sortWBinary(ar);


            return ar[n - 1];
        }

        public static int[] sortWBinary(int[] ar)
        {
            int count = 0;
            var swapped = true;
            for (int i = 0; i < ar.Length && swapped == true; i++)
            {
                swapped = false;
                for (int k = i, j = ar.Length - 1; k < ar.Length - i - 1 && j > 0; k++, j--)
                {
                    count++;
                    if (ar[k] > ar[k + 1])
                    {
                        var temp = ar[k];
                        ar[k] = ar[k + 1];
                        ar[k + 1] = temp;
                        swapped = true;
                    }

                    if (ar[j - 1] > ar[j])
                    {
                        var temp = ar[j - 1];
                        ar[j - 1] = ar[j];
                        ar[j] = temp;
                        swapped = true;
                    }
                }
            }

            return ar;
        }
    }
}
