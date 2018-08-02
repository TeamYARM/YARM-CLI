namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the entity for validation results.
    /// </summary>
    public class ValidationResults
    {
        /// <summary>
        /// Gets or sets a value indicating whether the input path is an HTTP URL or not.
        /// </summary>
        public bool IsInputHttp { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the input is YAML or not.
        /// </summary>
        public bool IsInputYaml { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the input is JSON or not.
        /// </summary>
        public bool IsInputJson { get; set; }

        /// <summary>
        /// Gets or sets the YAML file extension.
        /// </summary>
        public string YamlExtension { get; set; }

        /// <summary>
        /// Gets or sets the JSON file extension.
        /// </summary>
        public string JsonExtension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the output path is null or not.
        /// </summary>
        public bool IsOutputNullOrWhiteSpace { get; set; }
    }
}