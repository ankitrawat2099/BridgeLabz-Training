class Solution
{
    public bool CheckSubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum % k == 0 && i >= 1)
            {
                return true;
            }
            if (map.ContainsKey(sum % k))
            {
                int idx = map[sum % k];
                if (i - idx >= 2)
                {
                    return true;
                }
            }
            else
            {
                map.Add(sum % k, i);
            }
        }
        return false;
    }
}