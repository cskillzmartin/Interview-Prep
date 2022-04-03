using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class CordinatePairsFromVertex
    {
        public void DoStuff()
        {
            var hMap = new Dictionary<int, List<int>>();
            int[,] points = { { 1, 2 }, { 3, -1 }, { 2, 1 }, { 2, 3 } };
            int[] vertex = { 2, 2 };
            int k = 2;

            for (int i = 0; i < points.GetLength(0); i++)
            {
                var xDiff = Math.Abs(vertex[0] - points[i, 0]);
                var yDiff = Math.Abs(vertex[1] - points[i, 1]);
                int diff = xDiff + yDiff;

                if (!hMap.ContainsKey(diff))
                {
                    hMap.Add(diff, new List<int>() { i });
                }
                else
                {
                    hMap[diff].Add(i);
                }
            }

            int tempArLen = 0;
            var rtnAr = new int[hMap.Count];

            int ti = 0;
            foreach (var e in hMap)
            {
                rtnAr[ti] = e.Key;
                tempArLen += e.Value.Count;
                ti++;
            }

            //var swapped = true;
            //for (int i = 0; i < rtnAr.Length && swapped; i++)
            //{
            //    swapped = false;
            //    for (int a = i, j = rtnAr.Length - 1; a < rtnAr.Length - i - 1 && j > 0; a++, j--)
            //    {
            //        if (rtnAr[a] > rtnAr[a + 1])
            //        {
            //            var temp = rtnAr[a];
            //            rtnAr[a] = rtnAr[a + 1];
            //            rtnAr[a + 1] = temp;
            //            swapped = true;
            //        }

            //        if (rtnAr[j - 1] > rtnAr[j])
            //        {
            //            var temp = rtnAr[j - 1];
            //            rtnAr[j - 1] = rtnAr[j];
            //            rtnAr[j] = temp;
            //            swapped = true;
            //        }
            //    }
            //}
            Array.Sort(rtnAr);


            var RealRtnAr = new int[tempArLen];
            for (int i = 0; i < hMap[rtnAr[i]].Count; i++)
            {
                for (int j = 0; j < hMap[rtnAr[i]].Count; j++)
                {
                    RealRtnAr[i + j] = rtnAr[i];
                }
            }
        }
    }
}
