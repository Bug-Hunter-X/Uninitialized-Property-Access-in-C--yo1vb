public class ExampleClass
{
    public int MyProperty { get; set; } = 10; // Initialize the property

    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue; // Initialize via constructor
    }

    public void MyMethod()
    {
        int value = MyProperty;
        Console.WriteLine(value); // Output: 10 (or the constructor's initial value)
    }
}

//Alternative solution: null checks for reference types.
public class ExampleClass2
{
    public string MyString { get; set; } 

    public void MyMethod()
    {
        if (MyString != null) 
        {
            Console.WriteLine(MyString);
        }
        else
        {
            Console.WriteLine("MyString is null");
        }
    }
} 