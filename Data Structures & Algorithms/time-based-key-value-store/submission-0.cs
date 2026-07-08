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

        string result = "";
        if(!map.ContainsKey(key)) return result;
        
        List<(string value,int timestamp)> values = map[key];

        int left = 0 ; 
        int right = values.Count;

        while(left < right)
        {
            int mid = left + (right - left)/2;

            if(values[mid].timestamp <= timestamp)
            {
                result = values[mid].value;
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        return result;
        
    }
}
