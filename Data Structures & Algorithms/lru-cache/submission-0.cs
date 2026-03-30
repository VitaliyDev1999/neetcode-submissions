public class Node {
    public int Key { get; set; }
    public int Val { get; set; }
    public Node Prev { get; set; }
    public Node Next { get; set; }

    public Node(int key, int val) {
        Key = key;
        Val = val;
        Prev = null;
        Next = null;
    }
}

public class LRUCache {

    private readonly Dictionary<int, Node> _dict;
    private readonly int _capacity;
    private Node left;
    private Node right;

    public LRUCache(int capacity)
    {
        _dict = new Dictionary<int, Node>();
        _capacity = capacity;

        left = new Node(-1, -1);
        right = new Node(-1, -1);

        left.Next = right;
        right.Prev = left;
    }

    public int Get(int key)
    {
        if (_dict.ContainsKey(key))
        {
            var node = _dict[key];

            Remove(node);
            Insert(node);

            return node.Val;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (_dict.ContainsKey(key))
        {
            var node = _dict[key];

            Remove(node);
        }
        
        var newNode = new Node(key, value);
        _dict[key] = newNode;
        Insert(newNode);

        if(_dict.Count > _capacity)
        {
            var lru = left.Next;
            Remove(lru);
            _dict.Remove(lru.Key);
        }
    }

    private void Insert(Node node)
    {
        Node prev = right.Prev;
        prev.Next = node;
        node.Prev = prev;
        node.Next = right;
        right.Prev = node;
    }

    private void Remove(Node node)
    {
        Node prev = node.Prev;
        Node next = node.Next;

        prev.Next = next;
        next.Prev = prev;
    }
}
