using DiGi.GIS.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.SQLite.Classes
{
    /// <summary>
    /// Configuration class for SQLite data extraction options, extending the base <see cref="ExtractOptions"/>.
    /// </summary>
    public class SQLiteExtractOptions : ExtractOptions
    {
        /// <summary>
        /// Gets or sets the file path to the source SQLite database.
        /// </summary>
        [JsonInclude, JsonPropertyName("SourcePath")]
        public string SourcePath { get; set; } = null;

        /// <summary>
        /// Gets or sets the directory where the extracted data will be saved.
        /// </summary>
        [JsonInclude, JsonPropertyName("DestionationDirectory")]
        public string DestionationDirectory { get; set; } = null;

        /// <summary>
        /// Gets or sets a value indicating whether existing files in the destination directory should be updated during extraction.
        /// </summary>
        [JsonInclude, JsonPropertyName("UpdateExisting")]
        public bool UpdateExisting { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteExtractOptions"/> class with specified source path and destination directory.
        /// </summary>
        /// <param name="sourcePath">The file path to the source SQLite database.</param>
        /// <param name="destionationDirectory">The directory where extracted data should be saved.</param>
        public SQLiteExtractOptions(string sourcePath, string destionationDirectory)
            : base()
        {
            SourcePath = sourcePath;
            DestionationDirectory = destionationDirectory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteExtractOptions"/> class.
        /// </summary>
        public SQLiteExtractOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteExtractOptions"/> class using a JSON object for configuration.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> containing the extraction options.</param>
        public SQLiteExtractOptions(JsonObject jsonObject)
            : base(jsonObject)
        {
        }
    }
}