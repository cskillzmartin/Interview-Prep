using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview_Prep.Scrapp
{
    public class ScrappCode
    {
        public int FindMaxIndexfBelowTarget(int[] ar, int target)
        {
            for (int i = ar.Length - 1; i > 0; i--)
            {
                if (ar[i] < target)
                    return i;
            }

            return ar.Length - 1;
        }

        //public string finSub2(string value1, string value2)
        //{
        //    for (int i = 0; i < value1.Length; i++)
        //    {
        //        bool charExists = false;
        //        for (int j = 0; j < value2.Length; j++)
        //        {
        //            if (value1[i] == value2[j])
        //            {
        //                charExists = true;
        //                break;
        //            };
        //        }

        //        if (!charExists)
        //        {
        //            value1.Replace(value1[i], new char());
        //        }
        //    }
        //    return string.Empty;
        //}
    }
}