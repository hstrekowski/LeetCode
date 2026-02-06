namespace TwoSum;

class Program
{
    // public int[] TwoSum(int[] nums, int target)
    // {
    //     for (int i = 0; i < nums.Length - 1; i++)
    //     {
    //         for (int j = i + 1; j < nums.Length; j++)
    //         {
    //             if (nums[i] + nums[j] == target)
    //                 return [i, j];
    //         }
    //     }

    //     return [];
    // }
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> seenNumbers = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int neededValue = target - nums[i];

            if (seenNumbers.ContainsKey(neededValue))
            {
                return [seenNumbers[neededValue], i];
            }

            if (!seenNumbers.ContainsKey(nums[i]))
            {
                seenNumbers[nums[i]] = i;
            }
        }

        return [];
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
