namespace Sqrt;

class Program
{
    public static int MySqrt(int x)
    {
        if (x < 2) return x;
        int sqrt = 0;
        for (long i = 0; i * i <= x; i++)
        {
            sqrt = (int)i;
        }
        return sqrt;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(MySqrt(2147395600));
    }
}
