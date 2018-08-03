using System.Net.Http;
using System.Threading.Tasks;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This provides interfaces to the <see cref="Converter"/> class.
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Parses the input to output.
        /// </summary>
        /// <param name="options"><see cref="Options"/> instance.</param>
        /// <param name="client"><see cref="HttpClient"/> instance.</param>
        Task ParseAsync(Options options, HttpClient client);
    }
}