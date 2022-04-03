using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class FindLowestValueController : Controller
    {
        public ActionResult Index()
        {
            int[] ar1 = { 1, 6, 5, 11, 8, 6, 45, 7, 5, 10 };

            return View(FindLowest(ar1));
        }

        public int FindLowest(int[] ar)
        {
            int rtnValue = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < rtnValue)
                    rtnValue = ar[i];
            }

            return rtnValue;
        }
    }
}