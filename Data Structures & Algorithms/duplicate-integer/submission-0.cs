public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> map = new HashSet<int>();
        foreach(int n in nums){
            if(map.Contains(n)){
                return true;
            }
            map.Add(n);
        }
        return false;
    }
}