using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    public class FindMostOccuringKNumbers
    {

        public static int FindMax(Dictionary<int, int> value)
        {
            int rtnValue = 0;
            foreach (var e in value)
            {
                if (!value.ContainsKey(rtnValue))
                    rtnValue = e.Key;

                if (value[rtnValue] < e.Value)
                    rtnValue = e.Key;
            }
            return rtnValue;
        }

        public static void DoStuff()
        {
            int[] ar = { 1, 1, 1, 2, 2, 2, 3, 3, 4, 4, 4 };
            int k = 3;
            int[] rtnValue = new int[k];
            var arDictionary = new Dictionary<int, int>();

            int max = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (!arDictionary.ContainsKey(ar[i]))
                {
                    arDictionary.Add(ar[i], 1);
                }
                else
                {
                    arDictionary[ar[i]] = arDictionary[ar[i]] + 1;
                }

                if (arDictionary[ar[i]] > arDictionary[max])
                    max = ar[i];
            }

            rtnValue[0] = max;
            arDictionary.Remove(max);

            for (int i = 1; i < k; i++)
            {
                rtnValue[i] = FindMax(arDictionary);
                arDictionary.Remove(rtnValue[i]);
            }

            for (int i = 0; i < rtnValue.Length; i++)
            {
                Console.Write(rtnValue[i] + " ");
            }
        }
    }
}
