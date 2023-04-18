
// 152. Maximum Product Subarray
// https://leetcode.com/problems/maximum-product-subarray/

public class Solution {
    public int MaxProduct(int[] nums) {
        var maxProduct = nums.Max();
        (int curMin, int curMax) = (1, 1);
        
        foreach(var n in nums) {
            var tmp = curMax * n;
            
            curMax = new int[] {n, n * curMin, n * curMax}.Max();
            curMin = new int[] {n, n * curMin, tmp}.Min();
            
            maxProduct = Math.Max(maxProduct, curMax);
        }
        
        return maxProduct;
    }
}
        