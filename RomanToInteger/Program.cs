namespace RomanToInteger;

class Program
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> symbolValue = new Dictionary<char, int>()
        {
          {'I', 1},
          {'V', 5},
          {'X', 10},
          {'L', 50},
          {'C', 100},
          {'D', 500},
          {'M', 1000}
        };

        int sum = 0;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (symbolValue[s[i]] >= symbolValue[s[i + 1]]) sum += symbolValue[s[i]];
            else sum -= symbolValue[s[i]];
        }

        sum += symbolValue[s[s.Length - 1]];

        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
