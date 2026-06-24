public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs)
        {
            int sLength = s.Length;
            sb.Append(sLength).Append('#').Append(s);
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        int sLength = s.Length;
        int i = 0;

        while(i < sLength)
        {
            int j = i+1;

            while (s[j] != '#') j++;

            int subStringLength = int.Parse(s.Substring(i, j-i));

            j++;

            strs.Add(s.Substring(j,subStringLength));

            i = j+subStringLength;
        }
      return strs;

   }
}
