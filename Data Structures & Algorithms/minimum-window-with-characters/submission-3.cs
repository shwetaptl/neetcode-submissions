public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length) return "";
        int left = 0;
        int right = 0;
        int subStringCount = 0; 
        int minStart = 0;
        int minLength = int.MaxValue;
        Dictionary<char,int> map = new Dictionary<char,int>();

        foreach(char c in t)
        {
            if(!map.ContainsKey(c))
            {
                map[c]=0;
            }
            map[c] += 1;
        }

        while(right < s.Length)
        {
            if(map.ContainsKey(s[right]))
            {
                map[s[right]] -= 1;
                if(map[s[right]] == 0)
                {
                    subStringCount++;
                }
            }
            //minimum window found
            while(subStringCount == map.Count)
            {
                if(right - left + 1 < minLength)
                {
                    minLength = right - left + 1;
                    minStart = left;
                }

                //srink window
                if(map.ContainsKey(s[left]))
                {
                    if(map[s[left]] == 0)
                    {
                        subStringCount--;
                    }
                    map[s[left]] += 1;
                }
                left++;                                  
            }    
            right++;
        }

        if(minLength == int.MaxValue)
        {
            return "";
        }

        return s.Substring(minStart, minLength);
    }
}

//substring in while loop give o(n2) time complexity 