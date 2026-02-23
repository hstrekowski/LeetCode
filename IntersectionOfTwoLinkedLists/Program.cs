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
        ListNode dummy2 = headB;

        while (dummy1 != null)
        {
            while (dummy2 != null)
            {
                if (dummy2 == dummy1)
                {
                    return dummy2;
                }
                dummy2 = dummy2.next;
            }

            dummy2 = headB;
            dummy1 = dummy1.next;
        }

        return null;
    }
    static void Main()
    {
    }
}
