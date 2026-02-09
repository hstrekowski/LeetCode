namespace PlusOne;

class Program
{
    public int[] PlusOne(int[] digits)
    {
        digits[digits.Length - 1] = (digits[digits.Length - 1] + 1) % 10;

        for (int i = digits.Length - 1; i > 0; i--)
        {
            if (digits[i] == 0)
            {
                digits[i - 1] = (digits[i - 1] + 1) % 10;
            }
            else
            {
                break;
            }
        }

        return digits.All(x => x == 0) ? [1, .. new int[digits.Length]] : digits;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
