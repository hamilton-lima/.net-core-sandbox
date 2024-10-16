using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests;

public class HelloWorldConsoleTest
{
    [Fact]
    public void MessageContent()
    {
        // Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);

        // Act
        HelloWorld.Program.Main(new string[0]);

        // Assert
        var output = writer.GetStringBuilder().ToString().Trim();
        Assert.Equal("Hello, World!", output);
    }
}