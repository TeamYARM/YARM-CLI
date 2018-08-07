using System.Collections.Generic;
using System.Threading.Tasks;

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
        /// <param name="result"><see cref="ParserResult{Options}"/> instance.</param>
        /// <returns>Returns <see cref="Task"/>.</returns>
        Task ProcessAsync(IEnumerable<Error> errors, ParserResult<Options> result);
    }
}