public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        var setS = new Dictionary<char,int>();
        var setT = new Dictionary<char,int>();

        for(int i=0;i<s.Length;i++){
            if(!setS.TryAdd(s[i], 1)){
                setS[s[i]]++;
            }

            if(!setT.TryAdd(t[i], 1)){
                setT[t[i]]++;
            }
        }

        foreach(var el in setS) {
            if(setT.TryGetValue(el.Key, out int value)){
                if(value != el.Value)
                    return false;
            } else {
                return false;
            }
        }

        return true;
    }
}
