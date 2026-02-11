using System.ComponentModel;
using System.Data.SqlTypes;
using System.Text;

namespace ConvertBinNumberInALinkedListToInteger;


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
    public static int GetDecimalValue(ListNode head)
    {
        StringBuilder sb = new StringBuilder();

        while (head != null)
        {
            sb.Append(head.val);
            head = head.next;
        }

        return Convert.ToInt32(sb.ToString(), 2);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
