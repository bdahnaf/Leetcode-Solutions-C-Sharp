namespace LC_1290
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            ListNode node3 = new ListNode(1);
            ListNode node2 = new ListNode(0, node3);
            ListNode node1 = new ListNode(1, node2);
            int decimalValue = program.GetDecimalValue(node1);
        }
        public int GetDecimalValue(ListNode head)
        {
            return 0;
        }
    }
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
}