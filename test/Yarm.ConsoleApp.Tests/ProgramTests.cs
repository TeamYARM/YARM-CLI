using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yarm.ConsoleApp.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="Program"/> class.
    /// </summary>
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Given_ClassType_Should_BeStatic()
        {
            typeof(Program).Should().BeStatic();
        }

        [TestMethod]
        public void Given_ClassType_Should_HaveMethod()
        {
            typeof(Program).Should().HaveMethod("Main", new[] { typeof(string[]) })
                                    .Subject.IsStatic.Should().BeTrue(); ;
        }
    }
}