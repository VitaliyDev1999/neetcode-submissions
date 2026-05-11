public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));

        foreach (int stone in stones)
        {
            maxHeap.Enqueue(stone, stone);
        }

        while(maxHeap.Count > 1)
        {
            int y = maxHeap.Dequeue();
            int x = maxHeap.Dequeue();

            if (x == y)
                continue;

            if(x < y)
            {
                y -= x;
                maxHeap.Enqueue(y,y);
            }
                
        }

        return maxHeap.Count > 0 ? maxHeap.Dequeue() : 0;
    }
}
