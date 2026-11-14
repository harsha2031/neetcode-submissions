public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int l = weights.Max();
        int r = weights.Sum();
        int res = r;

        while(l <= r){
            int cap = (l + r) / 2;
            if(CanShip(cap, weights,days)){
                res = Math.Min(res, cap);
                r = cap - 1;
            }
            else{
                l = cap + 1;
            }
        }
        return res;
    }

    private bool CanShip(int cap, int[] weights, int days){
        int ships = 1;
        int currentCap = cap;

        foreach(int w in weights ){
            if(currentCap - w < 0){
                ships += 1;
                currentCap = cap;
            }
            currentCap -= w;
        }
        return ships <= days;
    }
}