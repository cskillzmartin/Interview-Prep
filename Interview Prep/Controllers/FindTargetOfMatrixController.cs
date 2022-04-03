using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class FindTargetOfMatrixController : Controller
    {
        // GET: FindTargetOfMatrix
        public ActionResult Index()
        {
            int target = 23;

            int[][] myMatrix = { new int[] { 1, 3, 5, 7, 9 }, new int[] { 11, 13, 15, 16, 20 }, new int[] { 21, 22, 23, 24, 25 }, new int[] { 30, 32, 35, 40, 45 } };
            for (int i = 0; i < myMatrix.Length; i++)
            {
                if (target <= myMatrix[i][4])
                {
                    TempData["rtnValue"] = returnMyNumber(myMatrix[i], target);
                    break;
                }
            }

            return View();
        }

        public int returnMyNumber(int[] ar, int target)
        {
            for (int i = 0, j = ar.Length - 1; i < ar.Length && j > 0; i++, j--)
            {
                if (ar[i] == target)
                    return ar[i];

                if (ar[j] == target)
                    return ar[j];
            }
            return -1;
        }
    }
}