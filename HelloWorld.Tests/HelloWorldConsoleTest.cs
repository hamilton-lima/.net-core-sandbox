using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_PrintsHelloWorld()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello, World!", output);
        }

        [Fact]
        public void Main_PrintsHelloWorld_IgnoresArguments()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[] { "Ignored", "Arguments" });

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Hello, World!", output);
        }

        [Fact]
        public void Main_PrintsHelloWorld_DoesNotPrintNewLine()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString();
            Assert.Equal("Hello, World!" + Environment.NewLine, output);
        }

        [Fact]
        public void Main_DoesNotThrowException()
        {
            // Arrange, Act, Assert
            var exception = Record.Exception(() => Program.Main(new string[0]));
            Assert.Null(exception);
        }

        [Fact]
        public void Main_PrintsToConsole_NotToStandardError()
        {
            // Arrange
            var originalOut = Console.Out;
            var originalError = Console.Error;
            var outputWriter = new StringWriter();
            var errorWriter = new StringWriter();
            Console.SetOut(outputWriter);
            Console.SetError(errorWriter);

            try
            {
                // Act
                Program.Main(new string[0]);

                // Assert
                Assert.Equal("Hello, World!" + Environment.NewLine, outputWriter.ToString());
                Assert.Empty(errorWriter.ToString());
            }
            finally
            {
                // Cleanup
                Console.SetOut(originalOut);
                Console.SetError(originalError);
            }
        }
    }
}