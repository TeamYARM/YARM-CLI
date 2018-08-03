using System.Collections.Generic;

using CommandLine;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yarm.ConsoleApp.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="ErrorHandler"/> class.
    /// </summary>
    [TestClass]
    public class ErrorHandlerTests
    {
        [TestMethod]
        public void Given_ClassType_Should_ImplementInterface()
        {
            typeof(ErrorHandler).Should().Implement<IErrorHandler>();
        }

        [TestMethod]
        public void Given_ClassType_Should_HaveMethod()
        {
            typeof(ErrorHandler).Should().HaveMethod("Process", new[] { typeof(IEnumerable<Error>) });
        }
    }
}