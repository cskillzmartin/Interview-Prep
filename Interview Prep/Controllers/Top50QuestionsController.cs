using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class Top50QuestionsController : Controller
    {
        public ActionResult Index()
        {

            return View(ReverseArray(OneToTen));
        }

        public int[] OneToTen { get { return new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; } }
        public int[] Duplicates { get { return new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4 }; } }
        public int[] buildArrayForTarget()
        {
            return new int[] { 10, 15, 11, 14, 55, 10, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 7, 2, 7, 9, 2, 1, 16, 89 };
        }
        public int[] BuildRandomIntArray()
        {
            var rando = new Random();
            var rtnValue = new int[100];
            for (int i = 0; i < 100; i++)
            {
                rtnValue[i] = rando.Next(1, 1000);
            }
            return rtnValue;
        }
        public int[] BuildArrayWithOutMissingNumber()
        {
            int[] ar = new int[100];
            for (int i = 0; i < 100; i++)
            {
                ar[i] = i;
            }
            return ar;
        }
        public int[] BuildArrayWithMissingNumber()
        {
            int[] ar = new int[100];
            for (int i = 0; i < 100; i++)
            {
                if (i != 15)
                    ar[i] = i;
            }
            return ar;
        }
        public int FindMissingInArray1(int[] ar)
        {
            int rtnValue = 0;
            int CheckSum = 0;
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                CheckSum += i;
            }

            for (int i = 0; i < ar.Count(); i++)
            {
                if (ar[i] != null)
                    sum += ar[i];
            }

            rtnValue = (CheckSum - sum);

            return rtnValue;
        }
        public int FindMissingInArray2(int[] ar)
        {
            var ar2 = BuildArrayWithOutMissingNumber();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] != ar2[i])
                    return ar2[i];
            }

            return 0;
        }
        public Dictionary<string, int> GetLargestAndSmallest(int[] ar)
        {
            var rtnValue = new Dictionary<string, int>() {
                {"Min", ar[0] },
                {"Max", ar[0] }
            };

            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] < rtnValue["Min"])
                    rtnValue["Min"] = ar[i];

                if (ar[i] > rtnValue["Max"])
                    rtnValue["Max"] = ar[i];
            }
            return rtnValue;
        }
        public List<KeyValuePair<int, int>> getAllPairsOfTarget(int[] ar, int target)
        {
            var candidates = new Dictionary<int, int>();
            var rtnValues = new List<KeyValuePair<int, int>>();

            for (int i = 0; i < ar.Length; i++)
            {
                if (candidates.ContainsKey(ar[i]))
                    rtnValues.Add(new KeyValuePair<int, int>(ar[i], candidates[ar[i]]));


                if (!candidates.ContainsKey(target - ar[i]))
                    candidates.Add(target - ar[i], ar[i]);
            }

            return rtnValues;
        }
        public IEnumerable<int> removeDuplicates(int[] ar)
        {
            var check = new HashSet<int>();
            IList<int> rtnValue = new List<int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (!check.Contains(ar[i]))
                {
                    check.Add(ar[i]);
                    rtnValue.Add(ar[i]);
                }
            }
            return rtnValue;
        }
        public int[] ReverseArray(int[] ar)
        {
            int[] rtnValue = new int[ar.Length];
            for (int i = 0, j = ar.Length - 1; i < j; i++, j--)
            {
                rtnValue[i] = ar[j];
                rtnValue[j] = ar[i];
            }

            return rtnValue;
        }
    }
}