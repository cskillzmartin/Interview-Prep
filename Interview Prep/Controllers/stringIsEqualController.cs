using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class stringIsEqualController : Controller
    {
        public ActionResult Index()
        {
            string[] Val = { "stringsdfgasdfhsd", "string" };
            return View(CheckDistanceIsLengthIsDifferent(Val));
        }

        public int CheckDistanceIsLengthIsDifferent(string[] ar)
        {
            int lengthDiff = ar[0].Length - ar[1].Length;
            if (lengthDiff < 0)
                return CheckDistance(ar, ar[0].Length) - lengthDiff;

            if (lengthDiff > 0)
                return CheckDistance(ar, ar[1].Length) + lengthDiff;

            return CheckDistance(ar);
        }

        public int CheckDistance(string[] ar, int upper = 0)
        {
            var rtnValue = 0;
            for (int i = 0; i < (upper == 0 ? ar[1].Length : upper); i++)
            {
                if (!stringIsEqual(ar[0][i], ar[1][i]))
                    rtnValue++;
            }

            return rtnValue;
        }

        public bool CheckFrom0(string[] ar)
        {
            if (ar[0].Length != ar[1].Length)
                return false;

            for (int i = 0; i < ar[1].Length; i++)
            {
                if (!stringIsEqual(ar[0][i], ar[1][i]))
                    return false;
            }
            return true;
        }

        public bool stringIsEqual(char alpha, char beta)
        {
            return alpha == beta;
        }
    }
}