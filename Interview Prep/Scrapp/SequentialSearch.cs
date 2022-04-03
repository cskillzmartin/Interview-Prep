using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview_Prep.Scrapp
{
    public class SequentialSearch
    {
        public int Search(int[] ar, int value)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == value)
                    return ar[i];
            }

            return -1;
        }

    }
}