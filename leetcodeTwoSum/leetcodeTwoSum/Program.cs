/*
    Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.
    Example 1:
    Input: nums = [2,7,11,15], target = 9
    Output: [0,1]
    Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
*/

namespace AbbreviateATwoWordName
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);
            
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }

        private static int[] TwoSum(int[] nums, int target)
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
                        return arr;
                    }
                }
            }

            return null;
        }
        
        //Approach 1: Brute Force
        //java
        /*class Solution {
            public int[] twoSum(int[] nums, int target) {
                for (int i = 0; i < nums.length; i++) {
                    for (int j = i + 1; j < nums.length; j++) {
                        if (nums[j] == target - nums[i]) {
                            return new int[] { i, j };
                        }
                    }
                }
                // In case there is no solution, we'll just return null
                return null;
            }
        }*/
        
        //Approach 2: Two-pass Hash Table
        //java
        /*class Solution {
            public int[] twoSum(int[] nums, int target) {
                Map<Integer, Integer> map = new HashMap<>();
                for (int i = 0; i < nums.length; i++) {
                    map.put(nums[i], i);
                }
                for (int i = 0; i < nums.length; i++) {
                    int complement = target - nums[i];
                    if (map.containsKey(complement) && map.get(complement) != i) {
                        return new int[] { i, map.get(complement) };
                    }
                }
                // In case there is no solution, we'll just return null
                return null;
            }
        }*/


        private double a = 1d;
        private float b = 2f;

    }
}