public class LRUCache
{
    private class DLinkedNode
    {
        public int key;
        public int value;
        public DLinkedNode prev;
        public DLinkedNode next;
        public DLinkedNode(int _key = 0, int _value = 0)
        {
            key = _key;
            value = _value;
        }
    }

    private int capacity;
    private Dictionary<int, DLinkedNode> cache = new();
    private DLinkedNode head, tail;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        head = new DLinkedNode();
        tail = new DLinkedNode();
        head.next = tail;
        tail.prev = head;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key)) return -1;

        DLinkedNode node = cache[key];
        MoveToHead(node);
        return node.value;
    }

    public void Put(int key, int value)
    {
        if (cache.ContainsKey(key))
        {
            DLinkedNode node = cache[key];
            node.value = value;
            MoveToHead(node);
        }
        else
        {
            DLinkedNode newNode = new DLinkedNode(key, value);
            cache[key] = newNode;
            AddNode(newNode);

            if (cache.Count > capacity)
            {
                DLinkedNode tailNode = PopTail();
                cache.Remove(tailNode.key);
            }
        }
    }

    // Add new node right after head
    private void AddNode(DLinkedNode node)
    {
        node.prev = head;
        node.next = head.next;
        head.next.prev = node;
        head.next = node;
    }

    // Remove an existing node from the list
    private void RemoveNode(DLinkedNode node)
    {
        node.prev.next = node.next;
        node.next.prev = node.prev;
    }

    // Move an existing node to the head
    private void MoveToHead(DLinkedNode node)
    {
        RemoveNode(node);
        AddNode(node);
    }

    // Pop the tail node
    private DLinkedNode PopTail()
    {
        DLinkedNode res = tail.prev;
        RemoveNode(res);
        return res;
    }
}
