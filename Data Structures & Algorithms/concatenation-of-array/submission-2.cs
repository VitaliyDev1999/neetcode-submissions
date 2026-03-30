public class Solution {
    public int[] GetConcatenation(int[] nums) {
         Array.Resize(ref nums, nums.Length * 2);
        for(int i = 0; i<nums.Length / 2; i++)
        {
            nums[i + nums.Length / 2] = nums[i];
        }
        return nums;
    }
}