public class Solution {
    public string MinWindow(string s, string t) {
        int left = 0;
        int right = 0;
        int subStringCount = 0; 
        string minWin = "";
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
                string window = s.Substring(left,right-left+1);
                if(minWin == "" || window.Length < minWin.Length)
                {
                    minWin = window;
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

        return minWin;
    }
}