using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> lastIndex = new Dictionary<char, int>();
        
        int maxLength = 0;
        int start = 0; 
        
        for (int end = 0; end < s.Length; end++) {
            char currentChar = s[end];
            
        
            if (lastIndex.ContainsKey(currentChar) && lastIndex[currentChar] >= start) {
                start = lastIndex[currentChar] + 1;
            }
            
          
            lastIndex[currentChar] = end;
            
         
            maxLength = Math.Max(maxLength, end - start + 1);
        }
        
        return maxLength;
    }
}
