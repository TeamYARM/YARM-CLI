using System.Collections.Generic;
using System.Threading.Tasks;

using CommandLine;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the error handler entity.
    /// </summary>
    public class ErrorHandler : IErrorHandler
    {
        /// <inheritdoc />
        public async Task ProcessAsync(IEnumerable<Error> errors, ParserResult<Options> result)
        {
            await Task.CompletedTask.ConfigureAwait(false);
        }
    }
}