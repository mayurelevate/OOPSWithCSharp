using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DSArray._1DArrayProblems
{
    // Problem Statement :
    
    //Given a 1D integer array nums, a peak element is an element that is strictly greater than its neighbors.Find a peak element and return its index(0-indexed). If the array contains multiple peaks, return the index of any of the peaks.
    //You may imagine that nums[-1] = -∞ and nums[n] = -∞. In other words, an element at the very beginning or the very end of the array only needs to be strictly greater than its single internal neighbor to be a peak.
    //Example 1:
    //• Input: nums = [1, 2, 3, 1]
    //• Output: 2
    //• Explanation: 3 is a peak element because it is greater than 2 and 1. Its index is 2.
    internal class Find_greater_neighbors
    {

        public void find_neighbour()
        {

            int[] nums = { 1, 2, 3, 1 };

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                // If the middle element is less than its right neighbor,
                // the peak must be in the right half.
                if (nums[mid] < nums[mid + 1])
                {
                    left = mid + 1;
                }
                // Otherwise, the peak is in the left half (including mid).
                else
                {
                    right = mid;
                }
            }

            // 'left' and 'right' converge to the peak element index
            Console.WriteLine($"Greater Neighbors Index : {left} and value of the index :{nums[left]}");

        }

    }
}
