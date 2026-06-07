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
                    DFS(grid, r, c);
                }
            }

        return islands;
    }

    private void DFS(char[][] grid, int r, int c)
    {
        if (r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || grid[r][c] == '0')
        {
            return;
        }

        grid[r][c] = '0';

        DFS(grid, r + 1, c);
        DFS(grid, r - 1, c);
        DFS(grid, r, c + 1);
        DFS(grid, r, c - 1);
    }
}