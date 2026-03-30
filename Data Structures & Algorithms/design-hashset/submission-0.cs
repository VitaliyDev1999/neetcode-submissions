public class MyHashSet {

    private int[] _array;

    public MyHashSet() {
        _array = new int[1000000];
    }
    
    public void Add(int key) {
        _array[key] = key;
    }
    
    public void Remove(int key) {
        _array[key] = -1;
    }
    
    public bool Contains(int key) {
        return _array[key] > 0;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */