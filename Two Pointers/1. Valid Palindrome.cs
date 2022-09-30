// My solution
public class Solution {
    public bool IsPalindrome(string s) {
        
        var start = 0;
        var end = s.Length - 1;
        while (start < end) {
            while (!char.IsLetterOrDigit(s[start])) {
                if (start >= end) break;
                start++;
            }
            while (!char.IsLetterOrDigit(s[end])) {
                if (start >= end) break;
                end--;
            }
            if (char.ToLower(s[start]) != char.ToLower(s[end])) return false;
            start++;
            end--;
        }
        return true;
    }
}

// Optimal solution
public class Solution {
    public bool IsPalindrome(string s) {
        
        var start = 0;
        var end = s.Length - 1;
        while (start < end) {
            if (!char.IsLetterOrDigit(s[start])) {
                start++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[end])) {
                end--;
                continue;
            }
            if (char.ToLower(s[start]) != char.ToLower(s[end])) return false;
            
            start++;
            end--;
        }
        return true;
    }
}