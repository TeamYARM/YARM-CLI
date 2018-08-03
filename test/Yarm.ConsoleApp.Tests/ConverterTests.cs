using System;
using System.Net.Http;
using System.Threading.Tasks;

using FluentAssertions;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Yarm.ConsoleApp.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="Converter"/> class.
    /// </summary>
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void Given_ClassType_Should_ImplementInterface()
        {
            typeof(Converter).Should().Implement<IConverter>();
        }

        [TestMethod]
        public void Given_ClassType_Should_HaveMethod()
        {
            typeof(Converter).Should().HaveMethod("ParseAsync", new[] { typeof(Options), typeof(HttpClient) })
                                      .Subject.ReturnType.Should().Be<Task>();
        }

        [TestMethod]
        public void Given_NullOptions_ParseAsync_ShouldThrow_Exception()
        {
            var converter = new Converter();

            Func<Task> func = async () => await converter.ParseAsync(null, null).ConfigureAwait(false);

            func.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_NullHttpClient_ParseAsync_ShouldThrow_Exception()
        {
            var converter = new Converter();

            Func<Task> func = async () => await converter.ParseAsync(new Options(), null).ConfigureAwait(false);

            func.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public void Given_NullInputPath_ParseAsync_ShouldThrow_Exception()
        {
            var converter = new Converter();

            Func<Task> func = async () => await converter.ParseAsync(new Options(), new HttpClient()).ConfigureAwait(false);

            func.Should().Throw<NullInputPathException>();
        }
    }
}