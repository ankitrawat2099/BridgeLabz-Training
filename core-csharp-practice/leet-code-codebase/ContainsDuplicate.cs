public class ContainsDuplicate {
    public bool ContainsDuplicate(int[] nums) {
        int count=0;
		//sorting the array
        Array.Sort(nums);
        if(nums.Length<=1){
            return false;
        }
        for(int i=0;i<nums.Length-1;i++){
          
		  //check for duplicates
                if(nums[i]==nums[i+1]){
                    count++;
                }
                if(count!=0){
                    return true;
                }
            }       
           
            return false;
    }
}