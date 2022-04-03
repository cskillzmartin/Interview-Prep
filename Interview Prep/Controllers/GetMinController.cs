using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class GetMinController : Controller
    {
        public ActionResult Index()
        {
            int[] ar = { 1, 3, 98, 78, 3, 5, 47, 6 };
            return View(getMin(ar));
        }

        public int getMin(int[] ar)
        {
            int rtnValue = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < rtnValue)
                    rtnValue = ar[i];
            }

            return rtnValue;
        }
    }
}