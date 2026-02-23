namespace PalindromeLinkedList;


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
    public static bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null) return true;

        Stack<int> stack = new Stack<int>();
        ListNode curr = head;

        while (curr != null)
        {
            stack.Push(curr.val);
            curr = curr.next;
        }

        curr = head;

        while (curr != null)
        {
            if (curr.val != stack.Pop()) return false;

            curr = curr.next;
        }

        return true;
    }
    static void Main(string[] args)
    {
    }
}
