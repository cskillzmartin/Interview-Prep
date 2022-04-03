using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class FizzBuzzController : Controller
    {
        public ActionResult Index()
        {
            return View(findFizzBuzz());
        }


        public IList<string> findFizzBuzz()
        {
            IList<string> rtnValue = new List<string>();
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    rtnValue.Add("Fizz & Buzz " + i.ToString());
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    rtnValue.Add("Buzz " + i.ToString());
                }
                else if (i % 5 != 0 && i % 3 == 0)
                {
                    rtnValue.Add("Fizz " + i.ToString());
                }
            }

            return rtnValue;
        }
    }
}