public class Solution {
    public int SplitArray(int[] nums, int k) {
        int l = nums.Max();
        int r = nums.Sum();
        int res = r;
        while(l <=r){
            int mid = l +(r - l)/2;
            if(CanSplit(mid, nums, k)){
                res = mid;
                r = mid -1;
            }
            else{
                l = mid +1;
            }
        }
        return res;
    }

    private bool CanSplit(int largest, int[] nums, int k){
        int current = 0;
        int subArray = 0;
        foreach(int n in nums){
            current += n;
            if(current > largest){
                subArray++;
                current = n;
            }
        }
        return subArray + 1 <= k;
    }
}