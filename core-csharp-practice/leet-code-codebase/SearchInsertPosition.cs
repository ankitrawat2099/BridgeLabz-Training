public class Solution {
    public int SearchInsert(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            if(nums[i]==target){
                return i;
            }
        }
        if(nums[0]>target){
            return 0;
        }
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i]<target && nums[i+1]>target){
                return i+1;
            }
        }
        return nums.Length;
    }
}