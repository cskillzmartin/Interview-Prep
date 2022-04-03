using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrep
{
    class ProcessListNodes
    {
               
        public void run()
        {
            var l1 = new ListNode(1)
            {
            };
            var l2 = new ListNode(9)
            {
                next = new ListNode(9)
            };

            string num1 = string.Empty;
            processNode(l1, l2, ref num1, 0);

            char[] sumChars = num1.ToCharArray().Reverse().ToArray<char>();

            var rtnValue = new ListNode(int.Parse(sumChars[0].ToString()));
            createNode(ref rtnValue, ref sumChars, 1);

            printNode(rtnValue);
        }

        private static void printNode(ListNode node)
        {
            Console.WriteLine(node.val);

            if (node.next != null)
                printNode(node.next);
        }



        private static void processNode(ListNode node1, ListNode node2, ref string num, int c)
        {
            if (node1 == null && node2 == null)
            {
                if (c != 0)
                    num = num.Insert(0, c.ToString());

                return;
            }


            int v1 = 0;
            int v2 = 0;

            if (node1 != null)
                v1 = node1.val;

            if (node2 != null)
                v2 = node2.val;

            var sum = v1 + v2 + c;
            var numAr = sum.ToString().ToArray();
            if (numAr.Length > 1)
            {
                c = int.Parse(numAr[0].ToString());
                num = num.Insert(0, numAr[1].ToString());
            }
            else
            {
                c = 0;
                num = num.Insert(0, numAr[0].ToString());
            }

            if (node1 == null)
            {
                if (node2.next == null)
                {
                    if (c != 0)
                        num = num.Insert(0, c.ToString());

                    return;
                }


                processNode(null, node2.next, ref num, c);
            }
            else if (node2 == null)
            {
                if (node1.next == null)
                {
                    if (c != 0)
                        num = num.Insert(0, c.ToString());

                    return;
                }


                processNode(node1.next, null, ref num, c);
            }
            else
            {
                processNode(node1.next, node2.next, ref num, c);
            }
        }


        private static void createNode(ref ListNode node, ref char[] nums, int numIndex)
        {
            if (nums.Length == numIndex)
                return;

            node.next = new ListNode(int.Parse(nums[numIndex].ToString()));
            numIndex += 1;

            createNode(ref node.next, ref nums, numIndex);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
