
//Single Number
public class Solution {
    public int SingleNumber(int[] nums) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

		for (int x = 0; x < nums.Length; x++)
		{
			if (dictionary.ContainsKey(nums[x]))
			{
				dictionary[nums[x]]++;
			}
			else
			{
				dictionary.Add(nums[x], 1);
			}
		}

		foreach (var i in dictionary)
		{
			if (i.Value == 1)
				return i.Key;
		}
		return -1;
	}
}
