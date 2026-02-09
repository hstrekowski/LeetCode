namespace ValidParentheses;

class Program
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 == 1) return false;

        Dictionary<char, int> counters = new Dictionary<char, int>()
        {
            {'(', 0},
            {'[', 0},
            {'{', 0},
        };

        List<char> closing = new List<char>() { '.'};

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                closing.Add(')');
                counters['(']++;
            }
            else if (s[i] == '[')
            {
                closing.Add(']');
                counters['[']++;
            }
            else if (s[i] == '{')
            {
                closing.Add('}');
                counters['{']++;
            }
            else if (s[i] == ')' && s[i] == closing[closing.Count - 1])
            {
                counters['(']--;
                closing.RemoveAt(closing.Count - 1);
            }
            else if (s[i] == ']' && s[i] == closing[closing.Count - 1])
            {
                counters['[']--;
                closing.RemoveAt(closing.Count - 1);
            }
            else if (s[i] == '}' && s[i] == closing[closing.Count - 1])
            {
                counters['{']--;
                closing.RemoveAt(closing.Count - 1);

            }
            else
            {
                return false;
            }
        }

        return counters.All(c => c.Value == 0);
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine(IsValid("()"));
    }
}
