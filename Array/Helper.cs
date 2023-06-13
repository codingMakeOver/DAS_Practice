namespace _11_Container_With_Most_Water;

/*
 * Problem : https://leetcode.com/problems/container-with-most-water/
 * We need to find the maximum area
 * so if you have given an array like [1,8,6,2,5,4,8,3,7] 
 * the answer will be 49
 * For doing that you need to give two pointer 
 * one for getting the current position of the left array(l) and one for right array(r)
 * set l = 0 and r = length-1
 * Now you need to compare the l and r and get the area 
 * like for i= 0 and r = a.length - 1 = 8
 * now you need to check who has minimum value , that position needs to be forwarded
 * min of a[l] and a[r]  => 1 and 7 
 * so will move the l pointer l++ else will move the r pointer r--
 * this loop will continue until l<r and simultaneously calculate the maximum area
 * maximum calculation formula : subtract the indexes (r-l) and multiply with minimum height 
 */

public static class Helper
{
    public static int MaxArea(int[] height)
    {
        int l = 0, r = height.Length - 1, mx = 0;
        while (l < r)
        {
            // get the minimum height
            int miniumHeight = Math.Min(height[l], height[r]);
            // get the maximum area
            mx = Math.Max(mx, miniumHeight* (r - l));
            // move the l or r position
            if (height[l] < height[r]) l++;
            else r--;
        }

        return mx;
    }
}
