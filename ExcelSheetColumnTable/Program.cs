using System.Text;

namespace ExcelSheetColumnTable;

class Program
{
    public static string ConvertToTitle(int columnNumber)
    {
        if (columnNumber-- <= 0) return string.Empty;

        string actual = ((char)((columnNumber % 26) + 65)).ToString();

        return ConvertToTitle(columnNumber / 26) + actual;
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine($"{27} - {ConvertToTitle(27)}");
    }
}
