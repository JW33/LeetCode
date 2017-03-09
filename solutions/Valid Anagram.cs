
//Valid Anagram
public class Solution {
    public bool IsAnagram(string s, string t) {
		if(s.Length != t.Length)
			return false;

		char[] chars_s = s.ToCharArray();
		char[] chars_t = t.ToCharArray();

		Array.Sort(chars_s);
		Array.Sort(chars_t);

		string word_s = new string(chars_s);
		string word_t = new string(chars_t);

		if (word_s == word_t)
			return true;

		return false;
    }
}
