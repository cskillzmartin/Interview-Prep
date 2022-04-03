using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class nthOrderSmallest2
    {
        public static void DoStuff()
        {
            int[] myAr = { 1, 1684, 3, 4, 5, 6, 7, 2, 98, 96, 0, 684, 654 };
            int nthOrder = 3;
            FindSmallestInt(ref myAr, 0, nthOrder, true, 0);

            Console.WriteLine();

            for (int i = 0; i < nthOrder; i++)
            {
                Console.WriteLine(myAr[i]);
            }
        }


        public static void FindSmallestInt(ref int[] ar, int start, int nthOrder, bool swapped, int cnt)
        {
            if (nthOrder == 0 || !swapped)
            {
                Console.WriteLine(cnt);
                return;
            }

            swapped = false;
            var min = ar[start];
            for (int i = start; i < ar.Length - 1; i++)
            {
                cnt++;
                if (ar[i] > ar[i + 1])
                {
                    var temp = ar[i];
                    ar[i] = ar[i + 1];
                    ar[i + 1] = temp;
                    swapped = true;
                }

                if (min > ar[i])
                {
                    var temp = min;
                    min = ar[i];
                    ar[i] = temp;
                    swapped = true;
                }
            }

            nthOrder -= 1;
            ar[start] = min;
            FindSmallestInt(ref ar, start + 1, nthOrder, swapped, cnt);
        }
    }
}
