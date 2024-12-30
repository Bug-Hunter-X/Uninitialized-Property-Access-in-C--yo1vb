public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized will result in the default value (0 for int)
        int value = MyProperty; 
        Console.WriteLine(value); // Output: 0

        // However, this can lead to unexpected behavior if you rely on the property having been set elsewhere
        // and it hasn't been set yet.
    }
}