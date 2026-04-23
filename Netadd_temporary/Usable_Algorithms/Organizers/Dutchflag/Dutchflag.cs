public class Solution {
    public void SortColors(int[] nums) {
        int low = 0;
        int mid = 0;
        int high = nums.Length - 1;

        while (mid <= high) {
            if (nums[mid] == 0) {
                Swap(nums, low, mid);
                low++;
                mid++;
            } 
            else if (nums[mid] == 1) {
                mid++;
            } 
            else { 
                Swap(nums, mid, high);
                high--;
            }
        }
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}

// I think this might be usefull for an optimized version of the research results algotithm,
// as it can be used to sort the results based on their relevance or other criteria. 
// The Dutch National Flag algorithm is efficient for sorting three distinct values, 
// which can be applied to categorize search results into three groups: highly relevant, moderately relevant, and irrelevant. 
// This way, we can quickly organize the search results and present the most relevant ones to the user first.  

//I still have to do some research on how this type of sorting can and is applied in search algorithms,
// but I believe it can be usefull in some way if that makes sense to the project.

// I'm going to keave this here for now as a way to visualize the structure of the "research results page".