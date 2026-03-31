public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        var queue = new PriorityQueue<(int value, int index), int>();

        int[] res = new int[n - k + 1];

        for (int r = 0; r < n; r++)
        {
            queue.Enqueue((nums[r],r), -nums[r]);
            if(r >= k - 1)
            {
                int left = r - k + 1;

                while (queue.Count > 0 && queue.Peek().index < left)
                {
                    queue.Dequeue();
                }

                res[left] = queue.Peek().value;
            }
        }

        return res;
    }
}
