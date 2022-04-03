using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class FirstReoccuringCharacterController : Controller
    {
        public ActionResult Index()
        {
            char[] ar = { 'a', 'b', 'c', 'a' };

            return View(findRecurring(ar));
        }

        public char? findRecurring(char[] ar)
        {
            var values = new Dictionary<char, int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (values.ContainsKey(ar[i]))
                    return ar[i];

                values.Add(ar[i], i);
            }

            return new char?();
        }
    }
}