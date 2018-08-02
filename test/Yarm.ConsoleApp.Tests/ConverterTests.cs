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
        public async Task Given_NullOptions_ParseAsync_ShouldThrow_Exception()
        {
            var converter = new Converter();

            Func<Task> func = async () => await converter.ParseAsync(null, null).ConfigureAwait(false);

            func.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public async Task Given_NullHttpClient_ParseAsync_ShouldThrow_Exception()
        {
            var converter = new Converter();

            Func<Task> func = async () => await converter.ParseAsync(new Options(), null).ConfigureAwait(false);

            func.Should().Throw<ArgumentNullException>();
        }

        [TestMethod]
        public async Task Given_NullInputPath_ParseAsync_ShouldThrow_Exception()
        {
            var converter = new Converter();

            Func<Task> func = async () => await converter.ParseAsync(new Options(), new HttpClient()).ConfigureAwait(false);

            func.Should().Throw<NullInputPathException>();
        }
    }
}