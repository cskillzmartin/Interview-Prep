using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class CloseToTargetController : Controller
    {
        public ActionResult Index()
        {
            var ar1 = new int[10] { 1, 6, 5, 11, 8, 6, 45, 7, 5, 10 };
            var ar2 = new int[10] { 20, 7, 5, 8, 3, 2, 4, 6, 11, 15 };

            var model = GetTarget(ar1, ar2, 25);

            return View(model);
        }


        public List<KeyValuePair<int, List<int>>> GetTarget(int[] ar1, int[] ar2, int target)
        {
            var rtnValue = new List<KeyValuePair<int, List<int>>>();
            for (int i = 0; i < ar1.Length; i++)
            {
                for (int j = 0; j < ar2.Length; j++)
                {
                    rtnValue.Add(new KeyValuePair<int, List<int>>(ar1[i] + ar2[j], new List<int>() { ar1[i], ar2[j] }));
                }
            }

            var lowest = rtnValue[0];

            for (int i = 0; i < rtnValue.Count; i++)
            {
                for (int j = 0; j < rtnValue.Count; j++)
                {
                    if (rtnValue[i].Key < rtnValue[j].Key)
                    {
                        lowest = rtnValue[i];

                        rtnValue[i] = rtnValue[j];

                        rtnValue[j] = lowest;
                    }
                }
            }



            return rtnValue;
        }
    }
}