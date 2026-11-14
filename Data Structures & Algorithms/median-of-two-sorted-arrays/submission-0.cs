public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] a = nums1;
        int[] b = nums2;
        int total = a.Length + b.Length;
        int half = (total + 1) / 2;
        if(b.Length < a.Length){
            int[] temp = a;
            a = b;
            b = temp;
        }
        int l = 0;
        int r = a.Length;
        while(l <= r){
            int i = (l + r)/ 2;
            int j = half - i;
            int aleft = i > 0 ? a[i-1] : int.MinValue;
            int aright = i < a.Length ? a[i] : int.MaxValue;
            int bleft = j > 0 ? b[j-1] : int.MinValue;
            int bright = j < b.Length ? b[j] : int.MaxValue;
            if(aleft <= bright && bleft <= aright){
                if(total % 2 != 0){
                    return Math.Max(aleft, bleft);
                }
                return (Math.Max(aleft, bleft) + Math.Min(aright, bright)) / 2.0;
            }
            else if(aleft > bright){
                r = i - 1;
            }else{
                l = i+1;
            }
        }
        return -1;
    }
}
