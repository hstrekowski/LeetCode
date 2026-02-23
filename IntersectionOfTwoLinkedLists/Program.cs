namespace IntersectionOfTwoLinkedLists;


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
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        ListNode dummy1 = headA;

        HashSet<ListNode> set = new HashSet<ListNode>();

        while (dummy1 != null)
        {
            set.Add(dummy1);
            dummy1 = dummy1.next;
        }

        ListNode dummy2 = headB;

        while (dummy2 != null)
        {
            if (set.Contains(dummy2)) return dummy2;

            dummy2 = dummy2.next;
        }

        return null;
    }
    static void Main()
    {
    }
}
