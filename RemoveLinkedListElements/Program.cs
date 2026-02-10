namespace RemoveLinkedListElements;


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
    public static ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null) return null;

        ListNode curr = head;

        while (curr != null && curr.next != null)
        {
            if (curr.next.val == val)
                curr.next = curr.next.next;
            else
            {
                curr = curr.next;
            }
        }

        return head.val == val ? head.next : head;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
