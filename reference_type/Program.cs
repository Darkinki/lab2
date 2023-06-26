using System;

public class Program
{
    static void Main()
    {
        int value = 10;
        MyClass reference = new MyClass();

        ModifyValue(value);
        ModifyReference(reference);

        Console.WriteLine("Value after modification: " + value);
        Console.WriteLine("Reference after modification: " + reference.Data);
    }

    static public void ModifyValue(int number)
    {
        number = 20;
    }

    static public void  ModifyReference(MyClass obj)
    {
        obj.Data = 20;
    }
}

public class MyClass
{
    public int Data { get; set; }
}