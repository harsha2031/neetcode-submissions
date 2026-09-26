public class Solution {
    public int MajorityElement(int[] nums) {
        int res = 0;
        int count = 0;
        foreach(int num in nums){
            if(count == 0){
                res = num;
            }
            if(res == num){
                count++;
            }else{
                count--;
            }
        }
        return res;
    }
}