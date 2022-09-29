// My solution
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> groupAnagrams = new Dictionary<string, List<string>>();
        foreach (string word in strs) {
            int[] intArray = new char[26];
            foreach (int letter in word) {  // doesn't work for certain case 10 b's then a c and 1b then t10 c's  ---> key becomes 101..... 101......
                intArray[letter - 'a']++;
            }
            string key = string.Join("", intArray);
            if (groupAnagrams.ContainsKey(key)) groupAnagrams[key].Add(word);
            else groupAnagrams.Add(key, new List<string>(){word});     
        }
        
        return groupAnagrams.Values.ToArray();
    }
}

// Optimal solution
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> groupAnagrams = new Dictionary<string, List<string>>();
        foreach (string word in strs) {
            char[] charArray = new char[26];
            foreach (char letter in word) {
                charArray[letter - 'a']++;
            }
            string key = string.Join("", charArray);
            if (groupAnagrams.ContainsKey(key)) groupAnagrams[key].Add(word);
            else groupAnagrams.Add(key, new List<string>(){word});     
        }
        
        return groupAnagrams.Values.ToArray();
    }
}