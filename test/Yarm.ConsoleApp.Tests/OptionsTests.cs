using CommandLine;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yarm.ConsoleApp.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="Options"/> class.
    /// </summary>
    [TestClass]
    public class OptionsTests
    {
        [TestMethod]
        public void Given_ClassType_Should_HaveProperties()
        {
            typeof(Options).Should().HaveProperty<string>("InputPath")
                                    .Subject.Should().BeDecoratedWith<OptionAttribute>();
            typeof(Options).Should().HaveProperty<string>("OuptputPath")
                                    .Subject.Should().BeDecoratedWith<OptionAttribute>();
        }
    }
}