using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class MostCommonOcurranceController : Controller
    {
        public ActionResult Index()
        {
            var rtnValue = new Dictionary<char, int>();
            for (int i = 0; i < ToSearch.Length; i++)
            {
                if (!rtnValue.ContainsKey(ToSearch[i]))
                {
                    rtnValue.Add(ToSearch[i], 1);
                }
                else
                {
                    rtnValue[ToSearch[i]] += 1;
                }
            }

            char MaxKey = new char();
            foreach (var e in rtnValue)
            {
                if (rtnValue.ContainsKey(MaxKey))
                {
                    if (rtnValue[e.Key] > rtnValue[MaxKey])
                        MaxKey = e.Key;
                }
                else
                {
                    MaxKey = e.Key;
                }
            }


            return View(MaxKey);
        }

        public string ToSearch { get { return "aabbbcc"; } }
    }
}