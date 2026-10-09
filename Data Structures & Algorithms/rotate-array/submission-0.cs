public class Solution {
    public void Rotate(int[] nums, int k) {
        int len = nums.Length;
        k = k % len;

        Reverse(nums, 0, len -1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, len -1);
    }
    private void Reverse(int[] nums, int left, int right){
        while(left < right){
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }
}