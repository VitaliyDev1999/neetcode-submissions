public class Solution {
    private int[][] directions = [
        [1, 0], [-1, 0],
        [0, 1], [0, -1]
    ];

    public void islandsAndTreasure(int[][] grid)
    {
        Queue<int[]> q = new Queue<int[]>();


        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    q.Enqueue([i, j]);
                }
            }

        if (q.Count == 0) return;

        while (q.Count > 0)
        {
            var node = q.Dequeue();

            int row = node[0];
            int col = node[1];

            foreach (var dir in directions)
            {
                int r = row + dir[0];
                int c = col + dir[1];

                if (r >= grid.Length || c >= grid[0].Length || r < 0 ||
                c < 0 || grid[r][c] != int.MaxValue)
                    continue;

                q.Enqueue([r, c,]);

                grid[r][c] = grid[row][col] + 1;
            }
        }
    }
}
