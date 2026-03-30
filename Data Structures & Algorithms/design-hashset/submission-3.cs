public class MyHashSet {

    private int[] _array;

    public MyHashSet() {
        _array = new int[8];
    }
    
    public void Add(int key) {
        if(key < _array.Length){
            _array[key] = key;
        }
        else{
            Resize(key);
            _array[key] = key;
        }   
    }
    
    public void Remove(int key) {
        if(key < _array.Length) {
            _array[key] = -1; 
        }
    }
    
    public bool Contains(int key)
    {
        return key < _array.Length && _array[key] > 0;
    }

    private void Resize(int length)
    {
        Array.Resize(ref _array, length+1);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */