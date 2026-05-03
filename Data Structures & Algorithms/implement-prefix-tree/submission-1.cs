public class TrieNode {
    public TrieNode[] children = new TrieNode[26];
    public bool isEndOfWord = false;
}

public class PrefixTree {

    private TrieNode root;

    public PrefixTree()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        var curr = root;

        foreach(char c in word)
        {
            if (curr.children[c - 'a'] == null)
            {
                curr.children[c - 'a'] = new TrieNode();
            }

            curr = curr.children[c - 'a'];
        }

        curr.isEndOfWord = true;
    }

    public bool Search(string word)
    {
        var curr = root;

        foreach (char c in word)
        {
            if (curr.children[c - 'a'] == null)
            {
                return false;
            }

            curr = curr.children[c - 'a'];
        }

        return curr.isEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var curr = root;

        foreach (char c in prefix)
        {
            if (curr.children[c - 'a'] == null)
            {
                return false;
            }

            curr = curr.children[c - 'a'];
        }

        return true;
    }
}
