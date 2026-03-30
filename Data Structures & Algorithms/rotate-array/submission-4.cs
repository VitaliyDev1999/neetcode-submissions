public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n;

        int[] rotated = new int[n];
        Array.Copy(nums, n - k, rotated, 0, k);
        Array.Copy(nums, 0, rotated, k, n - k);
        Array.Copy(rotated, nums, n);
    }
}