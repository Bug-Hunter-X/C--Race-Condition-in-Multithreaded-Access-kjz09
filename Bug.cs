public class ExampleClass
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void MyMethod()
    {
        // Some code here
        int localValue = Value; // This line might cause an error
        // More code here 
    }
}