public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];            // counts of 'A'..'Z' in the window
        int left = 0, best = 0;

        for (int right = 0; right < s.Length; right++)
        {
            count[s[right] - 'A']++;

            // changes needed = window length − most frequent letter's count
            while ((right - left + 1) - count.Max() > k)
            {
                count[s[left] - 'A']--;
                left++;
            }
            best = Math.Max(best, right - left + 1);
        }
        return best;

    }
}
