namespace leetcode_203
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = { 1, 2, 6, 3, 4, 5, 6 };
            int val = 6;
            int result = new Program().RemoveElements(head, val);
            Console.WriteLine("Hello, World!");
        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummyHead = new ListNode(0, head);
            ListNode temp = dummyHead;
            while (temp.next != null)
            {
                if (temp.next.val == val)
                {
                    temp.next = temp.next.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
            return dummyHead.next;
        }
    }

}