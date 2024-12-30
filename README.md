# Uninitialized Property Access in C#

This example demonstrates a subtle yet common error in C#: accessing a class property before it has been explicitly assigned a value.  While C# will provide default values (0 for integers, null for references), this can lead to unexpected behavior and bugs that are difficult to track down.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file offers improved solutions.  Always initialize properties to prevent such issues. Consider using constructor injection or property initialization to assign initial values, or use null-checks before using the property to avoid exceptions.