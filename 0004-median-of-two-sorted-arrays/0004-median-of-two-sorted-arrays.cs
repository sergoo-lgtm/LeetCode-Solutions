using System;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // تأكد إن nums1 هي الأصغر
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;

        int left = 0, right = m;

        while (left <= right) {
            int partitionX = (left + right) / 2;
            int partitionY = (m + n + 1) / 2 - partitionX;

            int maxLeftX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
            int minRightX = (partitionX == m) ? int.MaxValue : nums1[partitionX];

            int maxLeftY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];
            int minRightY = (partitionY == n) ? int.MaxValue : nums2[partitionY];

            // تحقق من صحة التقسيم
            if (maxLeftX <= minRightY && maxLeftY <= minRightX) {
                // لو العدد الكلي زوجي
                if ((m + n) % 2 == 0) {
                    return (Math.Max(maxLeftX, maxLeftY) + 
                            Math.Min(minRightX, minRightY)) / 2.0;
                }
                // لو فردي
                else {
                    return Math.Max(maxLeftX, maxLeftY);
                }
            }
            else if (maxLeftX > minRightY) {
                right = partitionX - 1;
            }
            else {
                left = partitionX + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted.");
    }
}
