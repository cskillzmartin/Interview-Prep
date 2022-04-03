using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview_Prep.Scrapp
{
    public class BinarySearch
    {
        public int Search(int[] ar, int value)
        {
            int mid;
            int low = 0;
            int high = ar.Length - 1;

            while (low <= high)
            {
                mid = low + (high - low) / 2;
                if (ar[mid] == value)
                    return mid;

                if (ar[mid] < value)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }
    }
}