using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class ExponentialOperator
    {
        public static double pow(int a, int b)
        {
            double rtnValue = a;
            bool convert = false;

            if (b == 0)
                return 1;

            if (b < 0)
            {
                convert = true;
                b = b * -1;
            }

            while (b != 1)
            {
                rtnValue *= a;
                b--;
            }

            if (convert)
                return 1 / rtnValue;


            return rtnValue;
        }

        public int[] ar = { -2, -3, 4, -1, -2, 1, 5, 3 };

        public static int SumTheSubArray(int[] ar, int begin, int end)
        {
            int rtnValue = 0;
            for (int i = begin; i <= end; i++)
            {
                rtnValue += ar[i];
            }

            return rtnValue;
        }
    }
}
