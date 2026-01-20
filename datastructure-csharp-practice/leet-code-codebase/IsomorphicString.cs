public class Solution {
    public bool IsIsomorphic(string s, string t) {
        string s1 = "", s2 = "";
        Dictionary<char, int> cnt1 = new Dictionary<char, int>();
        Dictionary<char, int> cnt2 = new Dictionary<char, int>();

        foreach (char ch in s) {
            if (!cnt1.ContainsKey(ch)) {
                cnt1[ch] = 1;
                s1 += ch;
            }
        }

        foreach (char ch in t) {
            if (!cnt2.ContainsKey(ch)) {
                cnt2[ch] = 1;
                s2 += ch;
            }
        }
        if (s1.Length != s2.Length){
            return false;}

        Dictionary<char, char> mapping = new Dictionary<char, char>();
        for (int i = 0; i < s1.Length; i++) {
            mapping[s1[i]] = s2[i];
        }
        string s3 = "";
        foreach (char ch in s) {
            s3 += mapping[ch];
        }

        return s3 == t;
    }
}