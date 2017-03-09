
//Add Digits
public class Solution {
    public int AddDigits(int num) {
        while(num >= 10)
		{
			char[] chars = num.ToString().ToCharArray();
			num = 0;
			foreach(char c in chars)
			{
				num += (int)Char.GetNumericValue(c);
			}
		}
		return num;
	}
}
