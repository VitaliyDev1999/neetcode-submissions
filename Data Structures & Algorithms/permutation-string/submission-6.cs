public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;
        
        bool res = false;

        int[] s1Arr = new int[26];
        int[] s2Arr = new int[26];
        int l = 0;

        for (int r = 0; r < s2.Length; r++)
        {
            if (r < s1.Length)
            {
                s1Arr[s1[r] - 'a']++;
            }
            else
            {
                if (s1Arr.SequenceEqual(s2Arr))
                {
                    return true;
                }
                else
                {
                    s2Arr[s2[l] - 'a']--;
                    l++;
                }
            }

            s2Arr[s2[r] - 'a']++;
        }

        return s1Arr.SequenceEqual(s2Arr);
        
    }
}
