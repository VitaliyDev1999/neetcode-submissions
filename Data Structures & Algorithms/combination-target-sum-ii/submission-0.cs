public class Solution {
    private List<List<int>> res = new List<List<int>>();

    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);

        void dfs(int idx, List<int> path, int cur)
        {
            if(cur == target)
            {
                res.Add([.. path]);
                return;
            }

            for (int i = idx; i < candidates.Length; i++)
            {
                if (i > idx && candidates[i] == candidates[i - 1])
                {
                    continue;
                }
                if (cur + candidates[i] > target)
                {
                    break;
                }

                path.Add(candidates[i]);
                dfs(i + 1, path, cur + candidates[i]);
                path.RemoveAt(path.Count - 1);
            }
        }

        dfs(0, new List<int>(), 0);

        return res;
    }
}
