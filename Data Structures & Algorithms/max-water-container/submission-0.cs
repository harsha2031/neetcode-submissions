public class Solution {
    public int MaxArea(int[] heights) {
        int result = Int32.MinValue;
        int l = 0;
        int r = heights.Length - 1;
        while(l<r){
            int volume = (r - l) * Math.Min(heights[l], heights[r]);
            result = Math.Max(volume, result);
            if(heights[l] < heights[r]){
                l++;
            }else{
                r--;
            }
        }
        return result;
    }
}
