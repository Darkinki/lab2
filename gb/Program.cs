using System;

class Program
{
    static void Main()
    {
        GarbageCollectorDemo();
    }

    static void GarbageCollectorDemo()
    {

        SomeClass obj = new SomeClass();

        obj.DoSomething();

        obj = null;

        GC.Collect();
        Console.WriteLine("Закінчили");
    }
}

class SomeClass
{
    public SomeClass()
    {
        Console.WriteLine("Створили");
    }
    public void DoSomething()
    {
        Console.WriteLine("Використали");
    }
}