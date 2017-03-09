

//Reverse String
public class Solution {
    public string ReverseString(string s) {
		int length = s.Length;
		int last = length - 1;

		char[] chars = s.ToCharArray();

		for(int x = 0; x < length / 2; x++)
		{
			char c = chars[x];
			chars[x] = chars[last - x];
			chars[last - x] = c;
		}
		return new string(chars);
    }
}
