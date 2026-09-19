public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var res = new int[temperatures.Length];
        Stack<int[]> stack = new Stack<int[]>(); // pair: [temp, index]

        for (int i = 0; i < temperatures.Length; i++)
        {   
            int t = temperatures[i];
            while (stack.Count > 0 && stack.Peek()[0] < t)
            {
                int[] pair = stack.Pop();
                res[pair[1]] = i - pair[1];
            }
            stack.Push(new int[] {t, i});
        }
        return res;
    }
}
