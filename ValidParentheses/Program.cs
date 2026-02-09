namespace ValidParentheses;

class Program
{
    public bool IsValid(string s)
    {
        Dictionary<char, int> counters = new Dictionary<char, int>()
        {
            {'(', 0},
            {'[', 0},
            {'{', 0},
        };

        char nextClose = string.Empty;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "(")
            {
                nextClose = ')';
                counters["("]++;
            }
            else if (s[i] == "[")
            {
                nextClose = ']';
                counters["["]++;
            }
            else if (s[i] == "{")
            {
                nextClose = '}';
                counters["{"]++;
            }
            else if (s[i] == ")" && s[i] == nextClose)
            {
                counters["("]--;
            }
            else if (s[i] == "]" && s[i] == nextClose)
            {
                counters["["]--;
            }
            else if (s[i] == "}" && s[i] == nextClose)
            {
                counters["{"]--;
            }
            else
            {
                return false;
            }
        }
    }
    static void Main(string[] args)
    {

    }
}
