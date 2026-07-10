public class Node
{
    public int key;
    public int val;
    public Node next;
    public Node prev;

    public Node(int key = -1 , int val = -1 , Node next = null, Node prev = null)
    {
        this.key = key;
        this.val = val;
        this.next = next;
        this.prev = prev;
    }
}

public class LRUCache {
    public int capacity;
    public Dictionary<int, Node> cache;
    public Node dummy;
    public Node curr;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, Node>();
        dummy = new Node();
        curr = dummy;
    }
    
    public int Get(int key) {
        if(!cache.ContainsKey(key))
        {
            return -1;
        }
        else
        {
            Node node = cache[key];
            int val = node.val;
            DeleteNode(node);
            InsertNode(key,val);
            return val;
        }
    }
    
    public void Put(int key, int value) {
        
        if(!cache.ContainsKey(key))
        {
            InsertNode(key,value);
        }
        else
        {
            Node node = cache[key];
            DeleteNode(node);
            InsertNode(key,value);
        }
        if(cache.Count > capacity)
        {
            Node deletedNode = dummy.next;
            cache.Remove(deletedNode.key);
            DeleteNode(deletedNode);
             
        }
    }

    public void InsertNode(int key, int value)
    {
        Node node = new Node(key,value);
        node.prev = curr;
        curr.next = node;
        curr = node;
        cache[key] = node;
    }

    public void DeleteNode(Node node)
    {
        if(node.next == null)
        {
            curr = node.prev;
            node.prev.next = null;
        }
        else
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
        }
    }
}
