using ExamPractice1.Controllers;
using Newtonsoft.Json;

namespace ExamPractice1.Model
{
    public class Item
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("latestReading")]
        public LatestReading LatestReading { get; set; }

        [JsonProperty("notation")]
        public string Notation { get; set; }

        [JsonProperty("parameter")]
        public string Parameter { get; set; }

        [JsonProperty("parameterName")]
        public string ParameterName { get; set; }

        [JsonProperty("period")]
        public int Period { get; set; }

        [JsonProperty("qualifier")]
        public string Qualifier { get; set; }

        [JsonProperty("station")]
        public string Station { get; set; }

        [JsonProperty("stationReference")]
        public string StationReference { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("valueType")]
        public string ValueType { get; set; }
    }
}
