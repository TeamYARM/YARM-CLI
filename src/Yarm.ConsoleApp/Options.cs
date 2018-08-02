using CommandLine;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the entity for command-line options.
    /// </summary>
    public class Options
    {
        /// <summary>
        /// Gets or sets the input file path.
        /// </summary>
        [Option('i', "input", Required = false, HelpText = "Input file name and path. If path is omitted, it assumes the current directory.")]
        public string InputPath { get; set; }

        /// <summary>
        /// Gets or sets the output file path.
        /// </summary>
        [Option('o', "output", Required = false, HelpText = "Output file name and path. If path is omitted, it assumes the current directory.")]
        public string OuptputPath { get; set; }
    }
}