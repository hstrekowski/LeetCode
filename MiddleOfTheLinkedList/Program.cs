namespace MiddleOfTheLinkedList;

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
    public static ListNode MiddleNode(ListNode head)
    {
        ListNode result = head;
        ListNode toEnd = head;

        while (toEnd != null && toEnd.next != null)
        {
            result = result.next;
            toEnd = toEnd.next.next;
        }

        return result;
    }
    static void Main()
    {

    }
}
