using Plat.Answer.LinkedList.Model;

namespace Plat.Answer.LinkedList
{
    public static class RecursiveExtension
    {
        /// <summary>
        /// 反转整个链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
            {
                return null;
            }
            if (head.Next == null)
            {
                return head;
            }
            var last = ReverseList(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return last;
        }
    }
}