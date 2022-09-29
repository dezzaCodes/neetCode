// My solution
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> contains = new HashSet<int>();
        foreach (int num in nums) {
            if (contains.Contains(num)) return true;
            else contains.Add(num);
        }
        return false;
    }
}

// Optimal solution
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> contains = new HashSet<int>();
        foreach (int num in nums) {
            if (contains.Contains(num)) return true;
            contains.Add(num);
        }
        return false;
    }
}