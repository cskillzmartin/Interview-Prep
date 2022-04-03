using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class FindSumController : Controller
    {

        public ActionResult Index()
        {
            //int[] ar2 = { 2, 4, 1, 11, 21, 31, 15, 1, 987, 12, 45, 78, 98, 987, 78, 289, 189, 87, 68, 798, 987, 9, 987, 78, 987, 87, 979, 87, 65, 95, 185, 2357, 27, 415, 46, 657, 48, 657, 489, 657, 486, 48, 987, 2, 3 };
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int target = 12;

            //return View(Search(ar2, target));
            return View(FindTarget(ar, target));
        }

        //assume not sorted
        public Dictionary<int, int> SetDiff(Dictionary<int, int> values, int diff, int index)
        {
            var rtnValue = values;
            if (!rtnValue.ContainsKey(diff))
                rtnValue.Add(diff, index);

            return rtnValue;
        }
        public KeyValuePair<bool, int[]> Search(int[] ar, int target)
        {
            var table = new Dictionary<int, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (table.ContainsKey(ar[i]))
                    return new KeyValuePair<bool, int[]>(true, new int[] { ar[i], ar[table[ar[i]]], i });

                table = SetDiff(table, target - ar[i], i);
            }

            return new KeyValuePair<bool, int[]>(false, new int[] { 0, 0 });
        }

        //assume sorted
        public KeyValuePair<bool, int[]> FindTarget(int[] ar, int target)
        {
            var rtnValue = new KeyValuePair<bool, int[]>(false, new int[] { 0, 0 });
            int[] bounds = setBound(ar, 0, ar.Length - 1, target);
            for (int i = bounds[0]; i < bounds[1]; i++)
            {
                bounds = setBound(ar, i, bounds[1], target);
                if (ar[bounds[0]] + ar[bounds[1]] == target)
                    rtnValue = new KeyValuePair<bool, int[]>(true, new int[] { ar[bounds[0]], ar[bounds[1]] });
            }

            return rtnValue;
        }
        public int[] setBound(int[] ar, int min, int max, int target)
        {
            if (ar[max] > target)
                return new int[2] { min, max - 1 };

            if (ar[min] + ar[max] < target)
                return new int[2] { min + 1, max };


            return new int[2] { min, max };
        }
    }
}