using System;

public class Program
{
    static public void Main()
    {
        int value = 10;
        MyClass reference = new MyClass();

        Console.WriteLine("Value type variable stored on stack: " + value);
        Console.WriteLine("Reference type variable stored on heap: " + reference);
    }
}

public class MyClass
{
    // Код класу
}