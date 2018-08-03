using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

using Yarm.Converters;

namespace Yarm.ConsoleApp
{
    /// <summary>
    /// This represents the converter entity.
    /// </summary>
    public class Converter : IConverter
    {
        /// <inheritdoc />
        public async Task ParseAsync(Options options, HttpClient client)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            var vr = ValidateOptions(options);
            SetOutputPath(options, vr);

            if (vr.IsInputYaml)
            {
                var yaml = await ReadFileAsync(options.InputPath, client).ConfigureAwait(false);
                var json = yaml.ToJson();

                File.WriteAllText(options.OuptputPath, json);

                return;
            }

            if (vr.IsInputJson)
            {
                var json = await ReadFileAsync(options.InputPath, client).ConfigureAwait(false);
                var yaml = json.ToYaml();

                File.WriteAllText(options.OuptputPath, yaml);

                return;
            }

            throw new FormatException("Invalid file extension");
        }

        private static bool IsYaml(string filepath, out string yamlExtension)
        {
            var extension = filepath.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries).Last().ToLowerInvariant();

            if (extension == "yaml" || extension == "yml")
            {
                yamlExtension = extension;

                return true;
            }

            yamlExtension = null;

            return false;
        }

        private static bool IsJson(string filepath, out string jsonExtension)
        {
            var extension = filepath.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries).Last().ToLowerInvariant();
            if (extension == "json")
            {
                jsonExtension = extension;

                return true;
            }

            jsonExtension = null;

            return false;
        }

        private static async Task<string> ReadFileAsync(string filepath, HttpClient client)
        {
            string content;
            if (filepath.StartsWith("http", StringComparison.InvariantCultureIgnoreCase))
            {
                content = await client.GetStringAsync(filepath).ConfigureAwait(false);

                return content;
            }

            content = await File.ReadAllTextAsync(filepath).ConfigureAwait(false);

            return content;
        }

        private static ValidationResults ValidateOptions(Options options)
        {
            if (string.IsNullOrWhiteSpace(options.InputPath))
            {
                throw new NullInputPathException();
            }

            var vr = new ValidationResults
                         {
                             IsInputHttp = options.InputPath.StartsWith("http", StringComparison.InvariantCultureIgnoreCase),
                             IsInputYaml = IsYaml(options.InputPath, out string yamlExtension),
                             YamlExtension = yamlExtension,
                             IsInputJson = IsJson(options.InputPath, out string jsonExtension),
                             JsonExtension = jsonExtension,
                             IsOutputNullOrWhiteSpace = string.IsNullOrWhiteSpace(options.OuptputPath)
                         };

            return vr;
        }

        private static void SetOutputPath(Options options, ValidationResults vr)
        {
            if (!vr.IsOutputNullOrWhiteSpace)
            {
                return;
            }

            if (vr.IsInputHttp)
            {
                var inputFilename = options.InputPath.Split(new[] { "/" }, StringSplitOptions.RemoveEmptyEntries).Last();
                options.OuptputPath = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}{Path.DirectorySeparatorChar}{inputFilename}";
            }
            else
            {
                options.OuptputPath = options.InputPath;
            }

            if (vr.IsInputYaml)
            {
                options.OuptputPath = options.OuptputPath.Replace($".{vr.YamlExtension}", ".json");
            }

            if (vr.IsInputJson)
            {
                options.OuptputPath = options.OuptputPath.Replace($".{vr.JsonExtension}", ".yaml");
            }
        }
    }
}