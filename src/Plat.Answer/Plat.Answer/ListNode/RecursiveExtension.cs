namespace Plat.Answer.ListNode
{
    public static class RecursiveExtension
    {
        /// <summary>
        /// 反转整个链表
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static Model.ListNode ReverseList(Model.ListNode head)
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