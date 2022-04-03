using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview_Prep.Scrapp
{
    public class ReverseArray
    {
        public void Reverse(int[] ar, int start, int end)
        {

            for (int i = start, j = end; i < j; i++, j--)
            {
                int temp = ar[i];
                ar[i] = ar[j];
                ar[j] = temp;
            }

        }

    }
}