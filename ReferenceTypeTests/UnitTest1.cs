using System;
using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void ModifyValueShouldModifyNumber()
    {
        int value = 10;
        
        Program.ModifyValue(value);

        Assert.AreEqual(10, value); 
    }

    [Test]
    public void ModifyReferenceShouldModifyData()
    {
        MyClass reference = new MyClass();

        Program.ModifyReference(reference);

        Assert.AreEqual(20, reference.Data); 
    }
}