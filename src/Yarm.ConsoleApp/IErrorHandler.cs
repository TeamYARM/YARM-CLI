using System.Collections.Generic;

using CommandLine;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This provides interfaces to the <see cref="ErrorHandler"/> class.
    /// </summary>
    public interface IErrorHandler
    {
        /// <summary>
        /// Processes the list of errors raised.
        /// </summary>
        /// <param name="errors">List of <see cref="Error"/> instances.</param>
        void Process(IEnumerable<Error> errors);
    }
}