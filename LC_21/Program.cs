namespace LC_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(3);
            list1.next.next = new ListNode(5);

            ListNode list2 = new ListNode(2);
            list2.next = new ListNode(4);
            list2.next.next = new ListNode(6);

            program.MergeTwoLists(list1, list2);
        }
        

         
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode mergedList = new ListNode();
            Console.WriteLine(list1.val);
            Console.WriteLine(list1.next.val);
            Console.WriteLine(list2.val);
            return mergedList;
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