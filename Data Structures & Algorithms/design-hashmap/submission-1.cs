public class MyHashMap {

    private int[] _array;

    public MyHashMap() {
        _array = new int[1000001];
        Array.Fill(_array, -1);
    }
    
    public void Put(int key, int value) {
        _array[key]=value;
    }
    
    public int Get(int key) {
        return _array[key];
    }
    
    public void Remove(int key) {
        _array[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */