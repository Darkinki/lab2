using System;
using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void ProgramExecutionShouldntThrowException()
    {
        TestDelegate testDelegate = () => {
            Program.Main();
        };

        Assert.DoesNotThrow(testDelegate);
    }
}