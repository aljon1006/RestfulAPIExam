using Newtonsoft.Json;

namespace ExamPractice1.Model
{
    public class LatestReading
    {
        [JsonProperty("@id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("dateTime")]
        public string DateTime { get; set; }

        [JsonProperty("measure")]
        public string Measure { get; set; }

        [JsonProperty("value")]
        public double Value { get; set; }
    }
}
