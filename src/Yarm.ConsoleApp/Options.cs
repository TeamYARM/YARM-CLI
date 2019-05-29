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
        [Option('i', "input", Required = true, HelpText = "Name or absolute path of source file.")]
        public string InputPath { get; set; }

        /// <summary>
        /// Gets or sets the output file path.
        /// </summary>
        [Option('o', "output", Required = false, HelpText = "Name or absolute path or output file. If omitted, assumes current directory and same filename with target extension.")]
        public string OuptputPath { get; set; }
    }
}