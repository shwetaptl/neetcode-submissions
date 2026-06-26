public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s2.Length < s1.Length) return false;

        int[] s1Arr = new int[26];
        int[] s2Arr = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Arr[s1[i] - 'a']++;
            s2Arr[s2[i] - 'a']++;
        }

        int left = 0;
        int right = s1.Length - 1;

        while(right < s2.Length)
        {
            if(IsPermutatedString(s1Arr,s2Arr)) return true;
            
            right++;
            if (right < s2.Length)
            {
                s2Arr[s2[left++] - 'a']--;
                s2Arr[s2[right] - 'a']++;
            }
        }
        return false;

    }
    
    private bool IsPermutatedString(int[] s1Arr, int[] s2Arr)
    {
        for(int i=0 ; i< 26 ; i ++)
        {
            if(s1Arr[i] != s2Arr[i]) 
            {
                return false;
            }
        }
        return true;
    }
}