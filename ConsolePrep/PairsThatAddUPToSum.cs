using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class PairsThatAddUPToSum
    {
        public void GetPairs()
        {
            int[] ar = { 1, 3, 2, 5, 46, 6, 7, 4 };
            int k = 5;
            var hMap = new Dictionary<int, int>();
            var rtnValue = new List<KeyValuePair<int, int>>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (!hMap.ContainsKey(k - ar[i]))
                    hMap.Add(k - ar[i], i);
            }

            for (int i = 0; i < ar.Length; i++)
            {
                if (hMap.ContainsKey(ar[i]))
                {
                    rtnValue.Add(new KeyValuePair<int, int>(ar[i], ar[hMap[ar[i]]]));
                    hMap.Remove(ar[hMap[ar[i]]]);
                    hMap.Remove(ar[i]);
                }

            }


            for (int i = 0; i < rtnValue.Count; i++)
            {
                Console.WriteLine(string.Format("({0},{1})", rtnValue[i].Key, rtnValue[i].Value));
            }
        }
    }
}
