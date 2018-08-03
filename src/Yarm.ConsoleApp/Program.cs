using System.Net.Http;

using CommandLine;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the entity of the console application.
    /// </summary>
    public static class Program
    {
        private static HttpClient _client = new HttpClient();
        private static IConverter _converter = new Converter();
        private static IErrorHandler _handler = new ErrorHandler();

        /// <summary>
        /// Invokes the console application.
        /// </summary>
        /// <param name="args">List of arguments.</param>
        public static void Main(string[] args)
        {
            var parser = new Parser(with => with.EnableDashDash = true);
            var result = parser.ParseArguments<Options>(args)
                               .WithParsed<Options>(options => _converter.ParseAsync(options, _client).Wait())
                               .WithNotParsed<Options>(errors => _handler.Process(errors));
        }
    }
}