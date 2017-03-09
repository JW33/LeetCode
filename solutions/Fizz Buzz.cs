
//Fizz Buzz
public class Solution {
    public IList<string> FizzBuzz(int n) {
		List<string> list = new List<string>();
        for(int x = 1; x <= n; x++)
		{
			if (x % 3 == 0 && x % 5 == 0)
			{
				list.Add("FizzBuzz");
			}
			else if (x % 5 == 0)
			{
				list.Add("Buzz");
			}
			else if (x % 3 == 0)
			{
				list.Add("Fizz");
			}
			else
			{
				list.Add(x.ToString());
			}                
		}
		return list;
    }
}
