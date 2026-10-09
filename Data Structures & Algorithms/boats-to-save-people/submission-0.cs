public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int res = 0;
        int l = 0;
        int r = people.Length - 1;

        while(l<=r){
            int remain = limit - people[r];
            r--;
            res++;
            if(l <=r && remain >= people[l]){
                l++;
            }
        }
        return res;
    }
}