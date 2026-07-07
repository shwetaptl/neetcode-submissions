public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] freq = new int[26];
        int maxFreq = 0 ; 
        int maxCount = 0 ; 
        foreach(char c in tasks)
        {
            freq[c - 'A']++;
            maxFreq = Math.Max(maxFreq, freq[c - 'A']);
        }

        for(int i = 0 ; i < 26; i++)
        {
            if(freq[i] == maxFreq)
            {
                maxCount++;
            }
        }
        int total = ((maxFreq - 1) * (n+1)) + maxCount;
        return Math.Max(tasks.Length, total);
    }
}
