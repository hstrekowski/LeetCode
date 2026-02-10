namespace RemoveDuplicatesFromSortedList;


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
class Program
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode curr = head;

        while (curr != null && curr.next != null)
        {
            if (curr.val == curr.next.val)
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }

        return head;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
