// Find the problem at https://leetcode.com/problems/two-sum/
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int v = 0; v <= nums.Length; v++)
        {
            for (int z = v + 1; z < nums.Length; z++)
            {
                if (nums[v] + nums[z] == target) return new int[] { v, z };
            }
        }

        return new int[0];
    }

    /*
        We should ideally use hashmaps for a O(n) time complexity:

        Python implementation:
        def twoSum(self, nums, target):
        d = {}
        for i, n in enumerate(nums):
            m = target - n
            if m in d:
                return [d[m], i]
            else:
                d[n] = i
    
    */
}