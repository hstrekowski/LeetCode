namespace Sqrt;

class Program
{
    public static int MySqrt(int x)
    {
        int sqrt = 0;
        for (long i = 0; i * i <= x; i++)
        {
            sqrt = (int)i;
        }
        return sqrt;
    }
    }
    static void Main(string[] args)
    {
        Console.WriteLine(MySqrt(2147395600));
    }
}
