// My implementation
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            
            if (numbers.ContainsKey(complement)) return new int[2]{numbers[complement], i};
            numbers.Add(nums[i], i);
        }
        
        return null;
    }
}

// Optimal implementation
Same