using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<object> linkedList = new LinkedList<object>();

        try
        {
            while (true)
            {
                object obj = new object();
                linkedList.AddLast(obj);
            }
        }
        catch (OutOfMemoryException)
        {
            Console.WriteLine("OutOfMemoryException occurred. LinkedList is full.");
        }
    }
}