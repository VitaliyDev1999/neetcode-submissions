public class Solution {
    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0) return 0;
        int rows = grid.Length, cols = grid[0].Length, islands = 0;

        for (int r = 0; r < rows; r++)
            for (int c = 0; c < cols; c++)
            {
                if (grid[r][c] == '1')
                {
                    islands++;
                    BFS(grid, r, c);
                }
            }

        return islands;
    }

    private void BFS(char[][] grid, int r, int c)
    {
        Queue<int[]> q = new Queue<int[]>();
        grid[r][c] = '0';
        q.Enqueue([r, c]);

        while (q.Count > 0) { 
            var node = q.Dequeue();

            int row = node[0];
            int col = node[1];

            TryEnqueue(grid, q, row + 1, col);
            TryEnqueue(grid, q, row - 1, col);
            TryEnqueue(grid, q, row, col + 1);
            TryEnqueue(grid, q, row, col - 1);
        }
    }

    private void TryEnqueue(char[][] grid, Queue<int[]> q, int r, int c)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '0')
            return;
        grid[r][c] = '0'; // mark immediately to avoid duplicates
        q.Enqueue([r, c]);
    }
}