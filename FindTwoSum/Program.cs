using System;

namespace FindTwoSum
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //     You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //     You can return the answer in any order.
    // Example 1:
    // Input: nums = [2,7,11,15], target = 9
    // Output: [0,1]
    // Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 5, 5, 11};
            int target = 10;
            Console.WriteLine(TwoSum(nums, target));
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var arr = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;
                        //Console.WriteLine(arr[0]);
                        //Console.WriteLine(arr[1]);
                        return arr;
                    }
                }
            }

            return null;
        }
    }
}