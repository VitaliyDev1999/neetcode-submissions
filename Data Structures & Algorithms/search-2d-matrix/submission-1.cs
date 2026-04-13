public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int left = 0, right = matrix[0].Length - 1;
        int ceil = 0, floor = matrix.Length - 1;
        int yMid = 0;

        while (ceil <= floor)
        {
        yMid = ceil + (floor - ceil) / 2;
        int val1 = matrix[yMid][left];
        int val2 = matrix[yMid][right];

        if (val2 < target)
        {
                ceil = yMid + 1;
        }
        else if(val1 > target)
        {
                floor = yMid - 1;
        }
        else if (val1 <= target && target <= val2)
        {
                break;
        }
        }

        while (left <= right)
        {
            int xMid = left + (right - left) / 2;
            int val = matrix[yMid][xMid];
            if (matrix[yMid][xMid] > target)
            {
                right = xMid - 1;
            }
            else if(matrix[yMid][xMid] < target)
            {
                left = xMid + 1;
            }
            else
            {
                return true;
            }
        }

        return false;

    }
}
