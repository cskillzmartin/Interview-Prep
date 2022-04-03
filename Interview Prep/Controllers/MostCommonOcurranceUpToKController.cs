using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class MostCommonOcurranceUpToKController : Controller
    {
        // GET: MostCommonOcurranceUpToK
        public ActionResult Index()
        {
            var ar1 = new int[] { 1, 1, 1, 2, 2, 3 };
            var target = 2;
            var ar2 = new int[target];
            var dict = getMCOK(ar1);
            ar2[0] = (int)dict[0];
            for (int i = 0, j = dict.Count - 1; i < dict.Count && j >= i; i++, j++)
            {
                if (ar2[0] < (int)dict[i])
                {
                    int holder = ar2[0];
                    ar2[0] = (int)dict[i];
                }
            }







            return View();
        }

        public OrderedDictionary getMCOK(int[] ar)
        {
            var dic = new OrderedDictionary();
            for (int i = 0; i < ar.Length; i++)
            {
                if (!dic.Contains(ar[i]))
                {
                    dic.Add(ar[i], 1);
                }
                else
                {
                    int newVal = (int)dic[ar[i]] + 1;
                    dic[ar[i]] = newVal;
                }
            }
            return dic;
        }


    }
}