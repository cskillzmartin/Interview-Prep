using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class SortStringWithoutAPIController : Controller
    {
        // GET: SortStringWithoutAPI
        public ActionResult Index()
        {
            var s1 = "a390testai";
            var s2 = "039aaiest";
            var rtnValue = string.Empty;
            var previous = s1[0];
            for (int i = 0; i < s1.Length; i++)
            {
                if (previous > s1[i])
                {
                    rtnValue += s1[i];
                }
                else
                {
                    rtnValue += previous;
                    previous = s1[i];
                }

            }
            TempData["rtnValue"] = rtnValue;



            return View();
        }

        public bool isNumeric(char c)
        {
            try
            {

                int rtnValue = (int)c;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}