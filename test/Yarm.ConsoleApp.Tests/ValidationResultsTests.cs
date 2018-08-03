using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yarm.ConsoleApp.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="ValidationResults"/> class.
    /// </summary>
    [TestClass]
    public class ValidationResultsTests
    {
        [TestMethod]
        public void Given_ClassType_Should_HaveProperties()
        {
            typeof(ValidationResults).Should().HaveProperty<bool>("IsInputHttp");
            typeof(ValidationResults).Should().HaveProperty<bool>("IsInputYaml");
            typeof(ValidationResults).Should().HaveProperty<bool>("IsInputJson");
            typeof(ValidationResults).Should().HaveProperty<string>("YamlExtension");
            typeof(ValidationResults).Should().HaveProperty<string>("JsonExtension");
            typeof(ValidationResults).Should().HaveProperty<bool>("IsOutputNullOrWhiteSpace");
        }
    }
}