
//First Unique Character in String
public class Solution {
    public int FirstUniqChar(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int x = 0; x < s.Length; x++)
            {
                if(dict.ContainsKey(s[x]))
                {
                    dict[s[x]]++;
                }
                else
                {
                    dict.Add(s[x], 1);
                }
            }

            foreach (var x in dict)
            {
                if (x.Value == 1)
                {
                    return s.IndexOf(x.Key);
                }
            }
            return -1;
    }
}
