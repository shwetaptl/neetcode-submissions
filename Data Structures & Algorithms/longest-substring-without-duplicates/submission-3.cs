public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        int left = 0 ;
        int right = 0;
        int maxLength = 0; 

        while(right < s.Length)
        { 
            if(!map.ContainsKey(s[right]))
            {
                map[s[right]] = right;
            }
            else
            {
                maxLength = Math.Max(maxLength, right-left);
                //srink window
                int targetIndex = map[s[right]];
                while(left <= targetIndex)
                {
                    map.Remove(s[left]);
                    left++;
                }
                map[s[right]] = right;
            }
            right++;
        }
        return Math.Max(maxLength, right - left);
    }
}
