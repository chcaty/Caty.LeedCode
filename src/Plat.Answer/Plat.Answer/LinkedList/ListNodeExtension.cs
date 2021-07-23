using Plat.Answer.LinkedList.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plat.Answer.LinkedList
{
    public static class ListNodeExtension
    {
        /// <summary>
        /// 两个链表的第一个公共节点
        /// 输入两个链表，找出它们的第一个公共节点。
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        /// <returns></returns>
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            ListNode n1 = headA;
            ListNode n2 = headB;

            while (n1 != n2)
            {
                n1 = n1 == null ? headB : n1.Next;
                n2 = n2 == null ? headA : n2.Next;
            }
            return n1;
        }
    }
}
