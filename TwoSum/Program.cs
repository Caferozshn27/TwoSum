using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        //It is a method that shows which numbers in the array will be obtained from the given target.
        //If the target is not found, null is returned.
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i]+nums[j] == target)
                    {
                        return new[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
