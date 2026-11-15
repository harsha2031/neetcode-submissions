public class MyCircularQueue
{
    private readonly int[] _data;
    private readonly int _capacity;
    private int _head;   // index of the front element
    private int _count;  // number of elements currently stored

    public MyCircularQueue(int k)
    {
        _capacity = k;
        _data = new int[k];
    }

    public bool EnQueue(int value)
    {
        if (IsFull()) return false;

        int tail = (_head + _count) % _capacity;
        _data[tail] = value;
        _count++;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty()) return false;

        _head = (_head + 1) % _capacity;
        _count--;
        return true;
    }

    public int Front() => IsEmpty() ? -1 : _data[_head];

    public int Rear() => IsEmpty() ? -1 : _data[(_head + _count - 1) % _capacity];

    public bool IsEmpty() => _count == 0;

    public bool IsFull() => _count == _capacity;
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */