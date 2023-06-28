using NUnit.Framework;

[TestFixture]
public class GarbageCollectorTests
{
    [Test]
    public void GarbageCollectorCollectRemovesUnusedObjects()
    {
        var obj = new SomeClass();

        obj.DoSomething();
        obj = null;
        System.GC.Collect();
        Assert.IsNull(obj);
    }
}