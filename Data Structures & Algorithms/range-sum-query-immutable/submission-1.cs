public class NumArray {

    int[] _prefixSum;

    public NumArray(int[] nums)
    {
        _prefixSum = new int[nums.Length];
        int cur=0;
        for (int i = 0; i < nums.Length; i++)
        {
            cur +=nums[i];
            _prefixSum[i] = cur;
        }
    }

    public int SumRange(int left, int right)
    {
        if(left == 0)
        {
            return _prefixSum[right];
        }
        return _prefixSum[right] - _prefixSum[left-1];
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */