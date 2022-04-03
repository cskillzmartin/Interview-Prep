using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class LogestCommonSubsequenceController : Controller
    {
        // GET: LogestCommonSubsequence
        public ActionResult Index()
        {
            var ar1 = "ABAZDCA";
            var ar2 = "BACBADZCG";

            var rtnValue = string.Empty;
            int StartSubSearch = 0;
            for (int i = 0; i < ar1.Length; i++)
            {
                char current = ar1[i];
                int l2index = 0;
                for (int j = StartSubSearch; j < ar2.Length; j++)
                {
                    if (ar2[j] == current)
                    {
                        l2index = j;
                        break;
                    }

                }
                if (l2index >= i)
                {
                    StartSubSearch = l2index;
                    rtnValue += current;
                }
            }

            TempData["rtnValue"] = rtnValue;

            return View();
        }
    }
}