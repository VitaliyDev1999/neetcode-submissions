public class Solution {
    public int[] GetConcatenation(int[] nums) {
        var ans = new int[nums.Length * 2];
        nums.Concat(nums).ToArray().CopyTo(ans, 0);
        return ans;
    }
}