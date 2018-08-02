using System.Collections.Generic;

using CommandLine;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the error handler entity.
    /// </summary>
    public class ErrorHandler
    {
        /// <summary>
        /// Processes the list of errors raised.
        /// </summary>
        /// <param name="errors">List of <see cref="Error"/> instances.</param>
        public void Process(IEnumerable<Error> errors)
        {
        }
    }
}