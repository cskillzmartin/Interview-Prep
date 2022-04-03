using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    public class SpiralRabbitHole
    {


        public static void DoStuff(int[][] matrix)
        {
            //int[][] matrix = new int[10][];
            //matrix[0] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[1] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[2] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[3] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[4] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[5] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[6] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[7] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[8] = new int[] { 1, 2, 3, 4, 5 };
            //matrix[9] = new int[] { 1, 2, 3, 4, 5 };


            if (matrix.Count() == 0)
                return;


            IList<int> rtnValue = new List<int>();
            int[] RowBeginEndColBeginEnd = { 0, matrix.Length - 1, 0, matrix[0].Length - 1 };
            int itemCount = matrix.Length * matrix[0].Length;

            if (matrix[0].Length > 1)
            {
                walkForward(ref matrix, ref RowBeginEndColBeginEnd, ref rtnValue, ref itemCount);
            }
            else
            {
                walkDown(ref matrix, ref RowBeginEndColBeginEnd, ref rtnValue, ref itemCount);
            }

            for (int i = 0; i < rtnValue.Count; i++)
            {
                Console.WriteLine(rtnValue[i]);
            }
        }

        public static void walkForward(ref int[][] ar, ref int[] bounds, ref IList<int> rtnValue, ref int itemCount)
        {
            for (int i = bounds[2]; i <= bounds[3]; i++)
            {
                rtnValue.Add(ar[bounds[0]][i]);
                itemCount--;
            }

            if (checkLast(ref itemCount))
                return;

            bounds[0] += 1;

            walkDown(ref ar, ref bounds, ref rtnValue, ref itemCount);
        }

        public static void walkDown(ref int[][] ar, ref int[] bounds, ref IList<int> rtnValue, ref int itemCount)
        {
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                rtnValue.Add(ar[i][bounds[3]]);
                itemCount--;
            }

            if (checkLast(ref itemCount))
                return;

            bounds[3] -= 1;

            walkBack(ref ar, ref bounds, ref rtnValue, ref itemCount);
        }

        public static void walkBack(ref int[][] ar, ref int[] bounds, ref IList<int> rtnValue, ref int itemCount)
        {
            for (int i = bounds[3]; i >= bounds[2]; i--)
            {
                rtnValue.Add(ar[bounds[1]][i]);
                itemCount--;
            }

            if (itemCount == 0)
                return;

            bounds[1] -= 1;

            walkUp(ref ar, ref bounds, ref rtnValue, ref itemCount);
        }

        public static void walkUp(ref int[][] ar, ref int[] bounds, ref IList<int> rtnValue, ref int itemCount)
        {
            for (int i = bounds[1]; i >= bounds[0]; i--)
            {
                rtnValue.Add(ar[i][bounds[2]]);
                itemCount--;
            }

            if (checkLast(ref itemCount))
                return;

            bounds[2] += 1;

            walkForward(ref ar, ref bounds, ref rtnValue, ref itemCount);
        }

        public static bool checkLast(ref int itemCount)
        {
            if (itemCount == 0)
                return true;

            return false;
        }
    }
}
