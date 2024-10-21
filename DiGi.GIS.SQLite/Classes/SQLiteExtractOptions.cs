using DiGi.GIS.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.GIS.SQLite.Classes
{
    public class SQLiteExtractOptions : ExtractOptions
    {
        [JsonInclude, JsonPropertyName("SourcePath")]
        public string SourcePath { get; set; } = null;

        [JsonInclude, JsonPropertyName("DestionationDirectory")]
        public string DestionationDirectory { get; set; } = null;

        [JsonInclude, JsonPropertyName("UpdateExisting")]
        public bool UpdateExisting { get; set; } = true;

        public SQLiteExtractOptions(string sourcePath, string destionationDirectory)
            : base()
        {
            SourcePath = sourcePath;
            DestionationDirectory = destionationDirectory;
        }

        public SQLiteExtractOptions()
            : base()
        {

        }

        public SQLiteExtractOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
