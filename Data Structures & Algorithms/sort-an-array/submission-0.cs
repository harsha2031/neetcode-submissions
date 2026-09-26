public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;
        for(int i = n/2 - 1;i>=0;i--){
            Heapify(nums,n,i);
        }
        for(int i = n-1;i>0;i--){
            Swap(nums, 0, i);
            Heapify(nums, i, 0);
        }
        return nums;
    }
    private void Heapify(int[] nums, int n, int i){
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if(left < n && nums[left] > nums[largest]){
            largest = left;
        }
        if(right < n && nums[right] > nums[largest]){
            largest = right;
        }
        if(largest != i){
            Swap(nums, i, largest);
            Heapify(nums, n, largest);
        }
    }

    private void Swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}