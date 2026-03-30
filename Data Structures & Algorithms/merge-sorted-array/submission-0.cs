public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if (m == 0) {
            Array.Copy(nums2, nums1, n);
            return;
        }
            
        if (n == 0)
            return;

        Array.Copy(nums2, 0, nums1, m, n);
        Array.Sort(nums1);
    }
}