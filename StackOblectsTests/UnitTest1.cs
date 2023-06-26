using System;
using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    [Test]
    public void ProgramExecution_Should_NotThrowException()
    {
        StringWriter consoleOutput = new StringWriter();
        Console.SetOut(consoleOutput);

        TestDelegate testDelegate = () => {
            Program.Main();
        };

        Assert.DoesNotThrow(testDelegate);
        Assert.AreEqual("Value type variable stored on stack: 10\r\n" +
                        "Reference type variable stored on heap: " + typeof(MyClass).FullName + "\r\n",
            consoleOutput.ToString());
    }
}
