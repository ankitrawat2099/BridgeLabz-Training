public class MissingNumber {
    public int MissingNumber(int[] nums) {
		//sorting the array
        Array.Sort(nums);
		//checking for missing number
        if(nums.Length!=nums[nums.Length-1]){
            return nums.Length;
        }
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=i){
                return i;
            }
        }
        return -1;
    }
}