public class ExampleClass
{
    private int _value;
    private readonly object _lock = new object(); // Add a lock object

    public int Value
    {
        get
        {
            lock (_lock) { return _value; } // Synchronize the getter
        }
        set
        {
            lock (_lock) { _value = value; } // Synchronize the setter
        }
    }

    public void MyMethod()
    {
        // Some code here
        int localValue;
        lock (_lock)
        {
            localValue = Value; // Access Value within a lock block
        }
        // More code here
    }
}
        