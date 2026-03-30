public class MyHashMap {

    private struct Cell
    {
        public bool isOccupied = false;

        public Cell()
        {
        }
    }
    private int[] _array;
    private Cell[] _cellArray;

    public MyHashMap() {
        _array = new int[8];
        _cellArray = new Cell[8];
    }
    
    public void Put(int key, int value) {
        if(key >= _array.Length){
            Resize(key);
        }
        _array[key]=value;
        _cellArray[key].isOccupied = true;
    }
    
    public int Get(int key) {
        if(key < _array.Length) {
            if(_cellArray[key].isOccupied)
                return _array[key];
            return -1;
        }
            
        return -1;
    }
    
    public void Remove(int key) {
        if(key < _array.Length) {
            _array[key] = -1;
            _cellArray[key].isOccupied = false;
        }
        
    }

    private void Resize(int length)
    {
        Array.Resize(ref _array, length+1);
        Array.Resize(ref _cellArray, length+1);
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */