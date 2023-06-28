using System;
using System.Collections.Generic;
using NUnit.Framework;

[TestFixture]
public class HeavyMemoryTests
{
    [Test]
    public void LinkedListAddLastIncreasesCount()
    {
        LinkedList<object> linkedList = new LinkedList<object>();
        object obj = new object();

        linkedList.AddLast(obj);

        Assert.AreEqual(1, linkedList.Count);
    }

    [Test]
    public void LinkedListAddLastAddsObjectToTheEnd()
    {
        LinkedList<object> linkedList = new LinkedList<object>();
        object obj1 = new object();
        object obj2 = new object();

        linkedList.AddLast(obj1);
        linkedList.AddLast(obj2);

        Assert.AreEqual(obj2, linkedList.Last.Value);
    }
}
