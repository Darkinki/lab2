using System;

public class Program
{
    static public void Main()
    {
        MyClass obj = new MyClass();
        obj = null;

        GC.Collect();

        Console.WriteLine("Garbage collection completed.");
    }
}

public class MyClass
{
    // Код класу
}