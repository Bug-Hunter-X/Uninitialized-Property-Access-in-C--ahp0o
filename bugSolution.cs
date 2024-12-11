public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize with a default value

    public void MyMethod()
    {
        // Now MyProperty is guaranteed to be initialized.
        int value = MyProperty * 2;
    }

    //Alternative - Initialize in Constructor
    public ExampleClass()
    {
        MyProperty = 0;
    }
} 