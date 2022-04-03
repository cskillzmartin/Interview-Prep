using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
   public class reverseInt
    {
        //Console.WriteLine(ReverseInt(2147483647));
        //Console.WriteLine(ReverseInt(1563847412));
        //Console.WriteLine(ReverseInt(-2147483412));
        //Console.WriteLine(ReverseInt(-2147483648));
        //Console.WriteLine(ReverseInt(-563847412));
        //1563847412
        public static int ReverseInt(int x)
        {
            var xStr = x.ToString().ToCharArray();

            reverseChars(ref xStr, xStr[0] == '-' ? 1 : 0);

            int.TryParse(new string(xStr), out x);

            return x;
        }

        public static void reverseChars(ref char[] param, int start)
        {
            for (int i = start, j = param.Length - 1; i <= j; i++, j--)
            {
                var temp = param[i];
                param[i] = param[j];
                param[j] = temp;
            }
        }
    }
}
