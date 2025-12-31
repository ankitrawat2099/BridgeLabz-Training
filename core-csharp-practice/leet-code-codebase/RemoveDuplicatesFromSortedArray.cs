public class Solution {
    public int removeDuplicates(int[] nums) {
        int count = 0;
        int reNum = int.MaxValue;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != reNum) {
                reNum = nums[i];
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}