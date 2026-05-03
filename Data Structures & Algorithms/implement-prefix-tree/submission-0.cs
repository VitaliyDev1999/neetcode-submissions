public class PrefixTree {

    private PrefixTree[] childrens;
    private bool isEndOfWord;
    private PrefixTree root;

    public PrefixTree()
    {
        childrens = new PrefixTree[26];
        isEndOfWord = false;
        root = this;
    }

    public void Insert(string word)
    {
        if (string.IsNullOrEmpty(word))
            return;

        var curr = root;

        foreach(char c in word)
        {
            if (curr.childrens[c - 'a'] == null)
            {
                curr.childrens[c - 'a'] = new PrefixTree();
            }

            curr = curr.childrens[c - 'a'];
        }

        curr.isEndOfWord = true;
    }

    public bool Search(string word)
    {
        var curr = root;

        foreach (char c in word)
        {
            if (curr.childrens[c - 'a'] == null)
            {
                return false;
            }

            curr = curr.childrens[c - 'a'];
        }

        return curr.isEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var curr = root;

        foreach (char c in prefix)
        {
            if (curr.childrens[c - 'a'] == null)
            {
                return false;
            }

            curr = curr.childrens[c - 'a'];
        }

        return true;
    }
}
