using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview_Prep.Sorting
{
    public class Sort
    {
        public static void Bubble(ref int[] ar)
        {
            int len = ar.Length;
            int i, j, temp;
            for (i = 0; i < len - 1; i++)
            {
                for (j = 0; j < len - i - 1; j++)
                {
                    if (More(ar[j], ar[j + 1]))
                    {
                        temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleWStop(ref int[] ar)
        {
            int len = ar.Length;
            int i, j, temp, stop = 1;
            for (i = 0; i < len - 1 && stop == 1; i++)
            {
                stop = 0;
                for (j = 0; j < len - i - 1; j++)
                {
                    if (More(ar[j], ar[j + 1]))
                    {
                        stop = 1;
                        temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
        }

        public static void Insertion(ref int[] ar)
        {
            int len = ar.Length;
            int i, j, temp;


            for (i = 0; i < len; i++)
            {
                temp = ar[i];
                for (j = i; j > 0 && More(ar[j - 1], temp); j--)
                {
                    ar[j] = ar[j - 1];
                }
                ar[j] = temp;
            }
        }

        public static void Selection(ref int[] ar)
        {
            int len = ar.Length;
            int i, j, max, temp;
            for (i = 0; i < len - 1; i++)
            {
                max = 0;
                for (j = 0; j < len - 1 - i; j++)
                {
                    if (More(ar[j], ar[max]))
                    {
                        max = j;
                    }
                }

                temp = ar[len - 1 - i];
                ar[len - 1 - i] = ar[max];
                ar[max] = temp;
            }
        }

        public static void Merge(int[] ar, int[] tempAr, int low, int mid, int max)
        {
            int lowStart = low;
            int lowStop = mid;
            int upperStart = mid + 1;
            int uppserStop = max;
            int count = low;

            while (lowStart <= lowStop & upperStart <= uppserStop)
            {
                if (ar[lowStart] < ar[upperStart])
                {
                    tempAr[count++] = ar[lowStart++];
                }
                else
                {
                    tempAr[count++] = ar[upperStart++];
                }

            }

            while (lowStart <= lowStop)
            {
                tempAr[count++] = ar[lowStart++];
            }

            while (upperStart <= uppserStop)
            {
                tempAr[count++] = ar[upperStart++];
            }

            for (int i = low; i < upperStart; i++)
            {
                ar[i] = tempAr[i];
            }
        }



        private static bool More(int val1, int val2)
        {
            return val1 > val2;
        }

        private static bool Less(int val1, int val2)
        {
            return val1 < val2;
        }
    }
}