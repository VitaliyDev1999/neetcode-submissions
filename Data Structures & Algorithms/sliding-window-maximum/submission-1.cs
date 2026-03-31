public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int[] res = new int[n - k + 1];

        for (int r = 0; r < n; r++)
        {
            queue.Enqueue(r, nums[r]);
            if(r >= k - 1)
            {
                int left = r - k + 1;

                while (queue.Count > 0 && queue.Peek() < left)
                {
                    queue.Dequeue();
                }

                res[left] = nums[queue.Peek()];
            }
        }

        return res;
    }
}
