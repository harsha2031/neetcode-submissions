public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length -1;
        while(left < right){
            if(s[left] != s[right]){
                return IsPalindrome(left+1, right, s) || IsPalindrome(left, right -1, s);
            }
            left++;
            right--;
        }
        return true;
    }
    private bool IsPalindrome(int l, int r, string s){
        while(l < r){
            if(s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}