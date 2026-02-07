public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> roman = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int total = 0;
        for (int i = 0; i < s.Length; i++) {
            if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]]) {
                total -= roman[s[i]]; // لو أصغر من اللي بعده نطرحه
            } else {
                total += roman[s[i]]; // غير كده نضيفه
            }
        }
        return total;
    }
}