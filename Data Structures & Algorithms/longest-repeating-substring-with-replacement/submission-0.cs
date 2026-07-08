public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int maxCount = 0;
        int left = 0 ;
        int right = 0;
        int longestChar = 0 ;
        
        while(right < s.Length)
        {   
            freq[s[right] - 'A']++;
            maxCount = Math.Max(maxCount, freq[s[right] - 'A']);

            while((right - left + 1) - maxCount > k)
            {
                freq[s[left++] - 'A'] --;
            }

            longestChar = Math.Max(longestChar, right - left + 1) ;
            right++ ; 
        }
        return longestChar;

    }
}
