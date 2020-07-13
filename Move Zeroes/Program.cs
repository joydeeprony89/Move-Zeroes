using System;

namespace Move_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 0, 1, 0, 12 };
            MoveZeroes(nums);
            Console.WriteLine("Hello World!");
        }

        public static void MoveZeroes(int[] nums)
        {
            for (int lastNonZeroIndex = 0, cur = 0; cur < nums.Length; cur++)
            {
                if(nums[cur] != 0)
                {
                    int temp = nums[cur];
                    int prev = nums[lastNonZeroIndex];
                    nums[lastNonZeroIndex++] = temp;
                    nums[cur] = prev;
                }
            }
        }
    }
}
