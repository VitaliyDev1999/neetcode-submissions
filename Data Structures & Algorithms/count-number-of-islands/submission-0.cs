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
                    FloodFill(grid, r, c, rows, cols);
                }
            }

        return islands;
    }

    private void FloodFill(char[][] grid, int r, int c, int rows, int cols)
    {
        if (r < 0 || c < 0 || r >= rows || c >= cols || grid[r][c] == '0') return;
        grid[r][c] = '0';
        FloodFill(grid, r + 1, c, rows, cols);
        FloodFill(grid, r - 1, c, rows, cols);
        FloodFill(grid, r, c + 1, rows, cols);
        FloodFill(grid, r, c - 1, rows, cols);
    }
}