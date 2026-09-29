public class TimeMap {

    Dictionary<string, List<(string value,int timestamp)>> map;
    public TimeMap() {
         map = new Dictionary<string, List<(string value,int timestamp)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key))
        {
            map[key] = new List<(string value,int timestamp)>();
        }
        map[key].Add((value,timestamp));
    }
    
    public string Get(string key, int timestamp) {
        if (!map.TryGetValue(key, out var list)) return "";

        int lo = 0, hi = list.Count - 1;
        string answer = "";

        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;

            if (list[mid].timestamp == timestamp)
                return list[mid].value;            // exact match → can't do better
            else if (list[mid].timestamp < timestamp)
            {
                answer = list[mid].value;          // valid candidate → remember it
                lo = mid + 1;                      // look for a later one
            }
            else
            {
                hi = mid - 1;                      // too late → go left
            }
        }
        return answer;
    }
}
