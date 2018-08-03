using System.Collections.Generic;

using CommandLine;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the error handler entity.
    /// </summary>
    public class ErrorHandler : IErrorHandler
    {
        /// <inheritdoc />
        public void Process(IEnumerable<Error> errors)
        {
        }
    }
}