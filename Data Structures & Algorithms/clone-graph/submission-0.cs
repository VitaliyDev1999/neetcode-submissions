/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node)
    {
        if (node == null) return null;
        var map = new Dictionary<Node, Node>();
        return Clone(node, map);
    }

    private Node Clone(Node n, Dictionary<Node, Node> map)
    {
        if(map.TryGetValue(n, out var existing)) return existing;
        var copy = new Node(n.val);
        map[n] = copy;
        foreach (var nei in n.neighbors) { 
            copy.neighbors.Add(Clone(nei,map));
        }

        return copy;
    }
}
