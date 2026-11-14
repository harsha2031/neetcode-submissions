/**
 * // This is MountainArray's API interface.
 * // You should not implement it, or speculate about its implementation
 * class MountainArray {
 *     public int Get(int index) {}
 *     public int Length() {}
 * }
 */

class Solution {
    private Dictionary<int, int> cache = new Dictionary<int, int>();

    private int Get(int index, MountainArray mountainArr) {
        if (!cache.ContainsKey(index)) {
            cache[index] = mountainArr.Get(index);
        }
        return cache[index];
    }

    private int BinarySearch(int l, int r, bool ascending, MountainArray mountainArr, int target) {
        while (l <= r) {
            int m = (l + r) >> 1;
            int val = Get(m, mountainArr);
            if (val == target) {
                return m;
            }
            if ((ascending && val < target) || (!ascending && val > target)) {
                l = m + 1;
            } else {
                r = m - 1;
            }
        }
        return -1;
    }

    public int FindInMountainArray(int target, MountainArray mountainArr) {
        int length = mountainArr.Length();

        // Find Peak
        int l = 1, r = length - 2, peak = 0;
        while (l <= r) {
            int m = (l + r) >> 1;
            int left = Get(m - 1, mountainArr);
            int mid = Get(m, mountainArr);
            int right = Get(m + 1, mountainArr);

            if (left < mid && mid < right) {
                l = m + 1;
            } else if (left > mid && mid > right) {
                r = m - 1;
            } else {
                peak = m;
                break;
            }
        }

        // Search left portion
        int res = BinarySearch(0, peak, true, mountainArr, target);
        if (res != -1) return res;

        // Search right portion
        return BinarySearch(peak, length - 1, false, mountainArr, target);
    }
}