using System.Text;

namespace LongestCommonPrefix;

class Program
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1) return strs[0];

        StringBuilder actualPrefix = new StringBuilder(strs[0]);

        for (int i = 1; i < strs.Length; i++)
        {
            if (actualPrefix.Length == 0) return string.Empty;
            if (actualPrefix.Length > strs[i].Length) actualPrefix = new StringBuilder(actualPrefix.ToString().Substring(0, strs[i].Length));

            for (int j = 0; j < actualPrefix.Length; j++)
            {
                if (strs[i][j] != actualPrefix[j])
                {
                    actualPrefix = new StringBuilder(actualPrefix.ToString().Substring(0, j));
                    break;
                }
            }
        }

        return actualPrefix.ToString();
    }
    static void Main()
    {
        System.Console.WriteLine(LongestCommonPrefix(["sigma", "sogm", "sig"]));
    }
}
