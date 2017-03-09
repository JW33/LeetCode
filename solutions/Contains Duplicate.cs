
//Contains Duplicate
public class Solution {
    public bool ContainsDuplicate(int[] nums) {

		if (nums.Length == 1)
                return false;

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

		foreach (var x in dictionary)
		{
			if (x.Value > 1)
				return true;
		}
		return false;
    }
}
