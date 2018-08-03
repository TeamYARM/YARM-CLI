using System;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yarm.ConsoleApp.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="NullInputPathException"/> class.
    /// </summary>
    [TestClass]
    public class NullInputPathExceptionTests
    {
        [TestMethod]
        public void Given_ClassType_Should_Inherit()
        {
            typeof(NullInputPathException).Should().BeDerivedFrom<Exception>();
        }

        [TestMethod]
        public void Given_Exception_Should_HavePropertyValues()
        {
            var message1 = "Hello World";
            var message2 = "Lorem Ipsum";
            var inner = new Exception(message2);

            var ex = new NullInputPathException();
            ex.Message.Should().BeEquivalentTo("Input path is null or white-space");

            ex = new NullInputPathException(message1);
            ex.Message.Should().BeEquivalentTo(message1);

            ex = new NullInputPathException(message1, inner);
            ex.Message.Should().BeEquivalentTo(message1);
            ex.InnerException.Should().BeOfType<Exception>()
              .Subject.Message.Should().BeEquivalentTo(message2);
        }
    }
}